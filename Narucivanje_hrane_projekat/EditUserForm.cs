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
        public EditUserForm(Korisnik korisnik)
        {
            InitializeComponent();
            global_korisnik= korisnik;
            btnKreiraj.Text="Izmeni podatke";
            txtUsername.Text=korisnik.Korisnicko_ime;
            txtPasswd.Text=korisnik.Sifra;
            txtIme.Text=korisnik.Ime;
            txtPrezime.Text=korisnik.Prezime;
            chbAdmin.Checked=korisnik.Admin;
        }
        

        public override void btnKreiraj_Click(object sender, EventArgs e)
        {
            if (!this.IsDisposed)
            {
                global_korisnik.Ime=txtIme.Text;
                global_korisnik.Korisnicko_ime=txtUsername.Text;
                global_korisnik.Sifra=txtPasswd.Text;
                global_korisnik.Prezime=txtPrezime.Text;
                global_korisnik.Admin=chbAdmin.Checked;
                MessageBox.Show("Izmene su uspesno zabelezene.");
                AdminForm.korisnici.DataSource=null;

                AdminForm.pOsvezi();
               
            }
            this.Close();
        }
    }
}
