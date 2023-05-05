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
    public partial class KlijentRestoranForm : Form
    {
        TextBox txtRestoran;
        public KlijentRestoranForm(TextBox txt)
        {
            InitializeComponent();
            lbRestorani.DataSource=LoginForm.restorani;
            txtRestoran=txt;
        }
        List<Restoran> filtrirani_restorani = LoginForm.restorani ;
        private void btnFilter_Click(object sender, EventArgs e)
        {
            filtrirani_restorani = new List<Restoran>();
            string ime_jela = txtJelo.Text;
            int id_restorana;
            if (ime_jela!=string.Empty)
            {
                foreach (Jelo jelo in LoginForm.jela)
                {
                    if (jelo.Naziv.Contains(ime_jela))
                    {
                        id_restorana=jelo.ID_Restoran;
                        foreach (Restoran restoran in LoginForm.restorani)
                        {
                            if (restoran.id==id_restorana)
                            {
                                filtrirani_restorani.Add(restoran);
                                break;
                            }
                        }
                    }
                }
            }
            else
                filtrirani_restorani=LoginForm.restorani;

            lbRestorani.DataSource=null;
            lbRestorani.DataSource=filtrirani_restorani;
        }

        private void lbRestorani_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = lbRestorani.SelectedIndex;
            if(index!=-1)
            {
                RezervacijaForm.id_restorana=filtrirani_restorani[index].id;
                txtRestoran.Text=filtrirani_restorani[index].Naziv;
                MessageBox.Show("Uspesno ste izabrali restoran "+filtrirani_restorani[index].Naziv);
                this.Close();
            }
        }

        private void KlijentRestoranForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            AdminForm.pOsvezi();
        }
    }
}
