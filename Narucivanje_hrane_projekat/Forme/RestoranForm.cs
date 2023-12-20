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
    public partial class RestoranForm : Form
    {
        Restoran restoran;
        bool nov_restoran = false;
        public RestoranForm(Restoran r)
        {
            InitializeComponent();
            restoran=r;
            if (!LoginForm.restorani.Contains(restoran))
            {
                nov_restoran=true;
            }
            else
            {
                btnSacuvaj.Text="Sacuvaj izmene";
                txtAdresa.Text=r.Adresa;
                txtKontakt.Text=r.Kontakt_telefon;
                txtNaziv.Text=r.Naziv;
            }
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (txtAdresa.Text.Length<3||txtNaziv.TextLength<3||txtKontakt.Text.Length<7)
            {
                MessageBox.Show("Molimo vas unesite ispravne podatke za svako polje.");
            }
            else if (!long.TryParse(txtKontakt.Text,  out long  kontakt))
            {
                MessageBox.Show("Broj telefona mora sadrzati samo cifre!");
            }
            else
            {  
                if (nov_restoran==true)
                {
                    Restoran r = new Restoran(txtNaziv.Text, txtAdresa.Text, kontakt.ToString());
                    if (r.Sacuvaj_restoran()==false)
                    {
                        MessageBox.Show("Restoran sa ovim podacima vec postoji, svako polje mora biti unikatno za sve restorane!");
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Uspesno je dodat restoran!"); 
                    }
                }
                else
                {
                    restoran.Naziv=txtNaziv.Text;
                    restoran.Adresa=txtAdresa.Text;
                    restoran.Kontakt_telefon=txtKontakt.Text;
                    MessageBox.Show("Uspesno su sacuvane izmene!");
                }
                AdminForm.pOsvezi();
                this.Close();
            }
        }

        
    }
}
