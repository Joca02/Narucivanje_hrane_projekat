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
    public partial class NovNalogForm : Form
    {
        public NovNalogForm()
        {
            InitializeComponent();
        }

        public virtual void btnKreiraj_Click(object sender, EventArgs e)
        {
            if (txtPasswd.Text.Length<3 || txtUsername.Text.Length<3 || txtIme.Text.Length<3|| txtPrezime.Text.Length<3)
            {
                MessageBox.Show("Sva polja moraju imati najmanje 3 karaktera!");
            }
            else
            {
                Korisnik nalog = new Korisnik(txtUsername.Text,txtPasswd.Text,txtIme.Text,txtPrezime.Text,chbAdmin.Checked);
                if (nalog.Sacuvaj_nalog()==false)
                    MessageBox.Show("Korisnicko ime je zauzeto!");
                else
                {
                    MessageBox.Show("Uspesno je kreiran nalog!");
                    this.Close();
                }
                   
            }
        }
    }
}
