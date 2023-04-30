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
        List<ListBox> liste;
        public static ListBox korisnici=new ListBox();
        ListBox restorani = new ListBox();
        ListBox rezervacije = new ListBox();
        ListBox jela = new ListBox();
        ListBox prilozi = new ListBox();
        ListBox dodaci = new ListBox();


        public delegate void Osvezi();
        public static Osvezi pOsvezi;
        public AdminForm()
        {
            InitializeComponent();
            liste= new List<ListBox>();
            restorani.DataSource=null;
            rezervacije.DataSource=null;
            jela.DataSource=null;
            prilozi.DataSource=null;
            dodaci.DataSource=null;

            korisnici.DataSource=LoginForm.korisnici;
            rezervacije.DataSource=LoginForm.rezervacije;
            restorani.DataSource=LoginForm.restorani;
            jela.DataSource=LoginForm.jela;
            prilozi.DataSource=LoginForm.prilozi;
            dodaci.DataSource=LoginForm.dodaci;

            korisnici.ContextMenuStrip=cmsKorisnici;
            rezervacije.ContextMenuStrip=cmsRezervacije;
            restorani.ContextMenuStrip=cmsRestorani;
            jela.ContextMenuStrip=cmsJela;
            dodaci.ContextMenuStrip=cmsDodaci;
            prilozi.ContextMenuStrip=cmsPrilozi;

            korisnici.MouseDoubleClick+=Korisnici_MouseDoubleClick;
            
        }

        private void Korisnici_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("Kliknuli ste na \n"+korisnici.SelectedItem);
        }

        public void Osvezi_Korisnicki_Listbox()
        {
            korisnici.DataSource=null;
            korisnici.DataSource=LoginForm.korisnici;
            pOsvezi-=Osvezi_Korisnicki_Listbox;
        }  

        public void Osvezi_Liste()
        {
            pnlListe.Controls.Clear();
           
            int y = 0;
            for(int i=0;i<liste.Count; i++)
            {
                int visina_liste = pnlListe.Height/liste.Count;
                int sirina_liste = pnlListe.Width;
                liste[i].Height=visina_liste;
                liste[i].Width=sirina_liste;
                liste[i].Top=y;
                y+=visina_liste;
                pnlListe.Controls.Add(liste[i]);
            }
        }
        private void chbKorisnici_CheckedChanged(object sender, EventArgs e)
        {
            if (chbKorisnici.Checked)
            {
                liste.Add(korisnici);
                
            }
            else
                liste.Remove(korisnici);
            Osvezi_Liste();
        }

        private void chbRezervacije_CheckedChanged(object sender, EventArgs e)
        {
            if (chbRezervacije.Checked)
            {
                liste.Add(rezervacije);

            }
            else
                liste.Remove(rezervacije);
            Osvezi_Liste();
        }

        private void chbRestorani_CheckedChanged(object sender, EventArgs e)
        {
            if (chbRestorani.Checked)
            {
                liste.Add(restorani);

            }
            else
                liste.Remove(restorani);
            Osvezi_Liste();
        }

        private void chbJela_CheckedChanged(object sender, EventArgs e)
        {
            if (chbJela.Checked)
            {
                liste.Add(jela);

            }
            else
                liste.Remove(jela);
            Osvezi_Liste();
        }

        private void chbPrilozi_CheckedChanged(object sender, EventArgs e)
        {
            if (chbPrilozi.Checked)
            {
                liste.Add(prilozi);

            }
            else
                liste.Remove(prilozi);
            Osvezi_Liste();
        }

        private void chbDodaci_CheckedChanged(object sender, EventArgs e)
        {
            if (chbDodaci.Checked)
            {
                liste.Add(dodaci);

            }
            else
                liste.Remove(dodaci);
            Osvezi_Liste();
        }

        private void izbrisiKorisnikaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            int index = korisnici.SelectedIndex;
            if (index!=-1)
            {
                LoginForm.korisnici.RemoveAt(index);
                pOsvezi+=Osvezi_Korisnicki_Listbox;
                pOsvezi();
            }
        }
        private void izmeniKorisnikaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            int index = korisnici.SelectedIndex;
            if (index!=-1)
            {
                EditUserForm form = new EditUserForm(LoginForm.korisnici[index]);
                form.Show();
                pOsvezi+=Osvezi_Korisnicki_Listbox;
            }
        }

        private void dodajKorisnikaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
