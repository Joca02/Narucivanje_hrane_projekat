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
        ListBox korisnici=new ListBox();
        ListBox restorani = new ListBox();
        ListBox rezervacije = new ListBox();
        ListBox jela = new ListBox();
        ListBox prilozi = new ListBox();
        ListBox dodaci = new ListBox();


        public delegate void Osvezi();
        public static Osvezi pOsvezi;
        Korisnik admin;
        public AdminForm(Korisnik korisnik)
        {
            InitializeComponent();
            liste= new List<ListBox>();
            admin=korisnik;
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
            rezervacije.MouseDoubleClick+=Rezervacije_MouseDoubleClick;
            restorani.MouseDoubleClick+=Restorani_MouseDoubleClick;
            prilozi.MouseDoubleClick+=Prilozi_MouseDoubleClick;
            jela.MouseDoubleClick+=Jela_MouseDoubleClick;
            dodaci.MouseDoubleClick+=Dodaci_MouseDoubleClick;
            
        }
       

        private void Osvezi_korisnicki_Listbox()
        {
            korisnici.DataSource=null;
            korisnici.DataSource=LoginForm.korisnici;
            if(pOsvezi!=null)
                pOsvezi-=Osvezi_korisnicki_Listbox;
        }  
        private void Osvezi_Restoran_listbox()
        {
            restorani.DataSource=null;
            restorani.DataSource=LoginForm.restorani;
            if (pOsvezi!=null)
                pOsvezi-=Osvezi_Restoran_listbox;
        }

        void Osvezi_Prilog_listbox()
        {
            prilozi.DataSource=null;
            prilozi.DataSource=LoginForm.prilozi;
            if (pOsvezi!=null)
                pOsvezi-=Osvezi_Prilog_listbox;
        }

        void Osvezi_Dodatak_listbox()
        {
            dodaci.DataSource=null;
            dodaci.DataSource=LoginForm.dodaci;
            if (pOsvezi!=null)
                pOsvezi-=Osvezi_Dodatak_listbox;
        }

        void Osvezi_jelo_listbox()
        {
            jela.DataSource=null;
            jela.DataSource=LoginForm.jela;
            if (pOsvezi!=null)
                pOsvezi-=Osvezi_jelo_listbox;
        }

        void Osvezi_rezervacije_listbox()
        {
            rezervacije.DataSource=null;
            rezervacije.DataSource=LoginForm.rezervacije;
            if (pOsvezi!=null)
                pOsvezi-=Osvezi_rezervacije_listbox;
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

        //KORISNIK
        //////////////////////////////////////////////////////////////////////////////////////
        private void izbrisiKorisnikaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            int index = korisnici.SelectedIndex;
            if (index!=-1)
            {
                if (LoginForm.korisnici[index]!=admin)  //da ne bih izbrisao sebe
                {
                    LoginForm.korisnici.RemoveAt(index);
                    pOsvezi+=Osvezi_korisnicki_Listbox;
                    pOsvezi();
                }
                else
                    MessageBox.Show("Ne mozete izbrisati svoj nalog dok ste ulogovani!");
               
            }
        }

        private void izmeniKorisnikaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            int index = korisnici.SelectedIndex;
            if (index!=-1)
            {
                EditUserForm form = new EditUserForm(LoginForm.korisnici[index]);
                form.Show();
                pOsvezi+=Osvezi_korisnicki_Listbox;
            }
        }

        private void dodajKorisnikaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Korisnik korisnik = new Korisnik("", "", "", "", false);
            EditUserForm form = new EditUserForm(korisnik);
            form.Show();
            pOsvezi+=Osvezi_korisnicki_Listbox;
        }

        private void Korisnici_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show(korisnici.SelectedItem.ToString());
        }
        //////////////////////////////////////////////////////////////////////////////////////
        
        //RESTORAN
        //////////////////////////////////////////////////////////////////////////////////////
        private void toolStripMenuItem3_Click(object sender, EventArgs e)   //brisanje restorana
        {
            int index = restorani.SelectedIndex;
            if (index!=-1)
            {
                LoginForm.restorani.RemoveAt(index);
                pOsvezi+=Osvezi_Restoran_listbox;
                pOsvezi();
            }
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)   //izmena podataka restorana
        {
            int index = restorani.SelectedIndex;
            if (index!=-1)
            {
                RestoranForm form = new RestoranForm(LoginForm.restorani[index]);
                form.Show();
                pOsvezi+=Osvezi_Restoran_listbox;
            }
        }

        private void dodajRestoranToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Restoran restoran = new Restoran();
            RestoranForm form = new RestoranForm(restoran);
            form.Show();
            pOsvezi+=Osvezi_Restoran_listbox;
        }
        private void Restorani_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show(restorani.SelectedItem.ToString());
        }
        //////////////////////////////////////////////////////////////////////////////////////

        //PRILOG
        //////////////////////////////////////////////////////////////////////////////////////
        private void toolStripMenuItem9_Click(object sender, EventArgs e)   //brisanje priloga
        {
            int index = prilozi.SelectedIndex;
            if (index!=-1)
            {
                LoginForm.prilozi.RemoveAt(index);
                pOsvezi+=Osvezi_Prilog_listbox;
                pOsvezi();
            }
        }

        private void toolStripMenuItem10_Click(object sender, EventArgs e)  //izmena priloga
        {
            int index = prilozi.SelectedIndex;
            if (index!=-1)
            {
                PrilogForm form = new PrilogForm(LoginForm.prilozi[index]);
                form.Show();
                pOsvezi+=Osvezi_Prilog_listbox;
            }
        }

        private void dodajPrilogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Prilog p = new Prilog();
            PrilogForm form= new PrilogForm(p);
            form.Show();
            pOsvezi+=Osvezi_Prilog_listbox;
        }
        private void Prilozi_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show(prilozi.SelectedItem.ToString());
        }
        //////////////////////////////////////////////////////////////////////////////////////

        //DODATAK
        //////////////////////////////////////////////////////////////////////////////////////
        private void toolStripMenuItem7_Click(object sender, EventArgs e)    //brisanje dodatka
        {
            int index = dodaci.SelectedIndex;
            if (index!=-1)
            {
                LoginForm.dodaci.RemoveAt(index);
                pOsvezi+=Osvezi_Dodatak_listbox;
                pOsvezi();
            }
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)   //izmena dodatka
        {
            int index = dodaci.SelectedIndex;
            if (index!=-1)
            {
                DodatakForm form = new DodatakForm(LoginForm.dodaci[index]);
                form.Show();
                pOsvezi+=Osvezi_Dodatak_listbox;
            }
        }

        private void dodajDodatakToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dodatak d = new Dodatak();
            DodatakForm form = new DodatakForm(d);
            form.Show();
            pOsvezi+=Osvezi_Dodatak_listbox;
        }
        private void Dodaci_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show(dodaci.SelectedItem.ToString());
        }
        //////////////////////////////////////////////////////////////////////////////////////

        //JELO
        //////////////////////////////////////////////////////////////////////////////////////
        private void toolStripMenuItem5_Click(object sender, EventArgs e)   //brisanje jela
        {

            int index = jela.SelectedIndex;
            if (index!=-1)
            {
                int id = LoginForm.jela[index].id;
                LoginForm.jela.RemoveAt(index);
                /*foreach(Rezervacija r in LoginForm.rezervacije)
                {
                    foreach(Jelo j in r.Porucena_jela)
                    {
                        if(j.id == id)
                        {
                            r.Ukupna_cena-=j.Cena;
                            r.Porucena_jela.Remove(j);
                            if (r.Porucena_jela.Count==0)
                                LoginForm.rezervacije.Remove(r);
                        }
                    }
                }*/

                for(int i=0;i<LoginForm.rezervacije.Count;i++)
                {
                    for(int j = 0; j<LoginForm.rezervacije[i].Porucena_jela.Count;j++)
                    {
                        if (LoginForm.rezervacije[i].Porucena_jela[j].id==id)
                        {
                            LoginForm.rezervacije[i].Ukupna_cena-=
                                LoginForm.rezervacije[i].Porucena_jela[j].Cena;
                            LoginForm.rezervacije[i].Porucena_jela.Remove(
                                LoginForm.rezervacije[i].Porucena_jela[j]);
                            j--;
                            if (LoginForm.rezervacije[i].Porucena_jela.Count==0)
                            {
                                LoginForm.rezervacije.Remove(LoginForm.rezervacije[i]);
                                i--;
                            }

                        }
                    }
                }
                pOsvezi+=Osvezi_jelo_listbox;
                pOsvezi();
            }
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)   //izmena jela
        {
            int index = jela.SelectedIndex;
            if (index!=-1)
            {
                JeloForm form = new JeloForm(LoginForm.jela[index]);
                form.Show();
                pOsvezi+=Osvezi_jelo_listbox;
            }
        }

        private void dodajJeloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Jelo j = new Jelo();
            JeloForm form = new JeloForm(j);
            form.Show();
            pOsvezi+=Osvezi_jelo_listbox;
        }
        private void Jela_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //MessageBox.Show(jela.SelectedItem.ToString());
            MessageBox.Show(LoginForm.jela[jela.SelectedIndex].Opis);
        }

        //////////////////////////////////////////////////////////////////////////////////////

        //REZERVACIJE
        //////////////////////////////////////////////////////////////////////////////////////
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            int index = rezervacije.SelectedIndex;
            if (index!=-1)
            {
                LoginForm.rezervacije.RemoveAt(index);
                pOsvezi+=Osvezi_rezervacije_listbox;
                pOsvezi();
            }
        }
        private void Rezervacije_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show(rezervacije.SelectedItem.ToString());
        }
        //////////////////////////////////////////////////////////////////////////////////////
    }
}
