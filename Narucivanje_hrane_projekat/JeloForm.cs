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
    public partial class JeloForm : Form
    {
        Jelo jelo;
        bool novo_jelo = false;
        public JeloForm(Jelo j)
        {
            InitializeComponent();
            jelo = j;
            if(!LoginForm.jela.Contains(jelo))
            {
                novo_jelo=true;
            }
            else
            {
                btnSacuvaj.Text="Sacuvaj izmene";
                txtNaziv.Text=j.Naziv;
                txtCena.Text=j.Cena.ToString();
                txtGramaza.Text=j.Gramaza.ToString();
                txtOpis.Text=j.Opis;
                txtRestoran.Text=j.ID_Restoran.ToString();
                chbPrilog.Checked=j.Prilog_obavezan;
            }
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (txtNaziv.Text.Length<2)
            {
                MessageBox.Show("Naziv jela mora imati bar 2 slova!");
            }
            else if (!long.TryParse(txtCena.Text, out long cena))
            {
                MessageBox.Show("Morate uneti ispravnu cenu!");
            }
            else if (!long.TryParse(txtGramaza.Text, out long gramaza))
            {
                MessageBox.Show("Morate uneti ispravnu gramazu!");
            }
            else if(!int.TryParse(txtRestoran.Text,out int id_restorana))
            {
                MessageBox.Show("Morate uneti ispravan ID restorana!");
            }
            else
            {
                if (novo_jelo==true)
                {
                    Jelo j = new Jelo(txtNaziv.Text, cena, gramaza,txtOpis.Text,id_restorana);
                    j.Prilog_obavezan=chbPrilog.Checked;
                    if (j.Sacuvaj_jelo()==false)
                    {
                        MessageBox.Show("Jelo sa unetim nazivom vec postoji u ovom restoranu, morate dodati jelo sa unikatnim nazivom!");
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Uspesno je dodato jelo!");
                    }
                }
                else
                {
                    jelo.Naziv=txtNaziv.Text;
                    jelo.Cena=cena;
                    jelo.Gramaza=gramaza;
                    jelo.Opis=txtOpis.Text;
                    jelo.ID_Restoran=id_restorana;
                    jelo.Prilog_obavezan=chbPrilog.Checked;
                    MessageBox.Show("Uspesno su sacuvane izmene!");
                }
                AdminForm.pOsvezi();
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IzaberiRestoranForm form = new IzaberiRestoranForm(txtRestoran);
            form.Show();
        }
    }
}
