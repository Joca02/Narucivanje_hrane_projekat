using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Narucivanje_hrane_projekat
{
    public partial class EditUserForm : NovNalogForm
    {
        Korisnik global_korisnik;
        bool nov_korisnik = false;
        public EditUserForm(Korisnik korisnik)
        {
            InitializeComponent();
            global_korisnik= korisnik;
            if (!LoginForm.korisnici.Contains(global_korisnik))
            {
                nov_korisnik=true;
                btnKreiraj.Text="Dodaj korisnika";
            }
            else btnKreiraj.Text="Izmeni podatke";

            txtUsername.Text=korisnik.Korisnicko_ime;
            txtPasswd.Text=korisnik.Sifra;
            txtIme.Text=korisnik.Ime;
            txtPrezime.Text=korisnik.Prezime;
            chbAdmin.Checked=korisnik.Admin;
        }

        bool provera_msbx = false;
        public override void btnKreiraj_Click(object sender, EventArgs e)
        {
            provera_msbx=!provera_msbx;
          
                if (txtIme.Text.Length<3||txtPasswd.Text.Length<3||txtPrezime.Text.Length<3||txtUsername.Text.Length<3)
                {
                    if (provera_msbx)
                    MessageBox.Show("Sva polja moraju sadrzati bar po 3 karaktera!");
                    return;
                }
                if (nov_korisnik==true)
                {
                    Korisnik korisnik = new Korisnik(txtUsername.Text, txtPasswd.Text, txtIme.Text, txtPrezime.Text, chbAdmin.Checked);
                    if (korisnik.Sacuvaj_nalog()==false)
                        {
                            if (provera_msbx)
                                MessageBox.Show("Korisnicko ime je zauzeto!");
                            return;
                        } 
                }
                else
                {
                    global_korisnik.Sifra=txtPasswd.Text;
                    global_korisnik.Korisnicko_ime=txtUsername.Text;
                    global_korisnik.Ime=txtIme.Text;
                    global_korisnik.Prezime=txtPrezime.Text;
                    global_korisnik.Admin=chbAdmin.Checked;

                }
                MessageBox.Show("Izmene su uspesno zabelezene.");
                AdminForm.pOsvezi();
                this.Close();
            
        }
    }
}
