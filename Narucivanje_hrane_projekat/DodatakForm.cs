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
    public partial class DodatakForm : Form
    {
        Dodatak dodatak;
        bool nov_dodatak = false;
        public DodatakForm(Dodatak d)
        {
            InitializeComponent();
            dodatak=d;
            if(!LoginForm.dodaci.Contains(dodatak))
            {
                nov_dodatak=true;
            }
            else
            {
                btnSacuvaj.Text="Sacuvaj izmene";
                txtNaziv.Text=d.Naziv_dodatka;
                txtCena.Text=d.Cena.ToString();
                txtGramaza.Text=d.Gramaza.ToString();
            }
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (txtNaziv.Text.Length<2)
            {
                MessageBox.Show("Naziv dodatka mora imati bar 2 slova!");
            }
            else if (!long.TryParse(txtCena.Text, out long cena))
            {
                MessageBox.Show("Morate uneti ispravnu cenu!");
            }
            else if(!long.TryParse(txtGramaza.Text, out long gramaza))
            {
                MessageBox.Show("Morate uneti ispravnu gramazu!");
            }
            else
            {
                if (nov_dodatak==true)
                {
                    Dodatak d = new Dodatak(txtNaziv.Text, cena,gramaza);
                    if (d.Sacuvaj_dodatak()==false)
                    {
                        MessageBox.Show("Dodatak sa unetim nazivom vec postoji, morate dodati dodatak sa unikatnim nazivom!");
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Uspesno je dodat dodatak!");
                    }
                }
                else
                {
                    dodatak.Naziv_dodatka=txtNaziv.Text;
                    dodatak.Cena=cena;
                    dodatak.Gramaza=gramaza;
                    MessageBox.Show("Uspesno su sacuvane izmene!");
                }
                AdminForm.pOsvezi();
                this.Close();
            }    
        }
    }
}
