using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Narucivanje_hrane_projekat
{
    public partial class PorucivanjeJelaForm : Form
    {
        Jelo jelo;
        List<Prilog> prilozi;
        List<Dodatak> dodaci;
        public PorucivanjeJelaForm(Jelo j)
        {
            InitializeComponent();
            jelo=new Jelo(j);//da bih napravio tacnu kopiju objekta kako mi se cena originalnog jela bez dodataka ne bi menjala

            dodaci=LoginForm.dodaci;
            prilozi=LoginForm.prilozi;

            clbDodaci.DataSource=dodaci;
            clbPrilog.DataSource=prilozi;
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            jelo.id_dodaci.Clear();

            foreach (int i in clbDodaci.CheckedIndices)
            {
                jelo.id_dodaci.Add(dodaci[i].id);
                jelo.Cena+=dodaci[i].Cena;
            }
            
            if (jelo.Prilog_obavezan==true && jelo.ID_Prilog==-1)
                MessageBox.Show(jelo.Naziv+" mora imati prilog!");
            else
            {
               foreach(Prilog p in prilozi)
                {
                    if(p.id==jelo.ID_Prilog)
                    {
                        jelo.Cena+=p.Cena;
                        break;
                    }    
                }
                MessageBox.Show("Uspesno je dodato jelo u porudzbinu");
                
                this.Close();
            }
        }

        private void clbPrilog_ItemCheck(object sender, ItemCheckEventArgs e)
        {

            for (int i = 0; i < clbPrilog.Items.Count; i++)
            {
                if (i != e.Index)
                {
                    clbPrilog.SetItemChecked(i, false);
                }
            }

            jelo.ID_Prilog=prilozi[e.Index].id;
        }

        private void clbDodaci_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (clbDodaci.CheckedItems.Count >=3 &&e.NewValue==CheckState.Checked)
            {
                e.NewValue=CheckState.Unchecked;
                MessageBox.Show("Jelo moze imati maksimalno 3 dodatka!");
            }
            else if (e.NewValue==CheckState.Unchecked)
                e.NewValue=CheckState.Unchecked;
            else
                e.NewValue=CheckState.Checked;

        }

        private void PorucivanjeJelaForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            RezervacijaForm.rezervacija.Porucena_jela.Add(jelo);
            AdminForm.pOsvezi();
        }
    }
}
