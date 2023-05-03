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
    public partial class PrilogForm : Form
    {
        Prilog prilog;
        bool nov_prilog = false;
        public PrilogForm(Prilog p)
        {
            InitializeComponent();
            prilog=p;
            if(!LoginForm.prilozi.Contains(prilog))
            {
                nov_prilog=true;
            }
            else
            {
                btnSacuvaj.Text="Sacuvaj izmene";
                txtNaziv.Text=p.Naziv_priloga;
                txtCena.Text=p.Cena.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtNaziv.Text.Length<2)
            {
                MessageBox.Show("Naziv priloga mora imati bar 2 slova!");
            }
            else if (!long.TryParse(txtCena.Text, out long cena))
            {
                MessageBox.Show("Morate uneti ispravnu cenu!");
            }
            else
            {
                if(nov_prilog==true)
                {
                    Prilog p=new Prilog(txtNaziv.Text,cena);
                    if(p.Sacuvaj_prilog()==false)
                    {
                        MessageBox.Show("Prilog sa unetim nazivom vec postoji, morate dodati prilog sa unikatnim nazivom!");
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Uspesno je dodat prilog!");
                    }
                }
                else
                {
                    prilog.Naziv_priloga=txtNaziv.Text;
                    prilog.Cena=cena;
                    MessageBox.Show("Uspesno su sacuvane izmene!");
                }
                AdminForm.pOsvezi();
                this.Close();
            }
        }
    }
}
