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
    public partial class AdminForm : Form
    {
        public delegate void Osvezi();
        public static Osvezi pOsvezi;
        public AdminForm()
        {
            InitializeComponent();
            pOsvezi+=Osvezi_Korisnicki_Listbox;
        }

        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("Kliknuli ste na \n"+lbKorisnici.SelectedItem);
        }

       

        public void Osvezi_Korisnicki_Listbox()
        {
            lbKorisnici.Items.Clear();
            foreach (Korisnik korisnik in LoginForm.korisnici)
            {
                lbKorisnici.Items.Add(korisnik);
            }
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            Osvezi_Korisnicki_Listbox();
        }

        private void izbrisiKorisnikaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(lbKorisnici.SelectedItem != null)
            {
                for(int i=0;i<LoginForm.korisnici.Count;i++)
                {
                    if (LoginForm.korisnici[i].ToString()==lbKorisnici.SelectedItem.ToString())
                    {
                        LoginForm.korisnici.RemoveAt(i);
                        lbKorisnici.Items.Remove(lbKorisnici.SelectedItem);
                    }
                }
            }    
                
        }

        private void izmeniKorisnikaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lbKorisnici.SelectedItem != null)
            {
                foreach(Korisnik korisnik in LoginForm.korisnici)
                {
                    if(korisnik.ToString()==lbKorisnici.SelectedItem.ToString())
                    {
                        EditUserForm form = new EditUserForm(korisnik);
                        form.Show();
                    }
                }    
            }
        }
    }
}
