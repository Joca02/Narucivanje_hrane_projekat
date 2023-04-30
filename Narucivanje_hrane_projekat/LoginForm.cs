using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Narucivanje_hrane_projekat
{
    public partial class LoginForm : Form
    {
        public static List<Korisnik> korisnici=new List<Korisnik>();
        public static List<Jelo> jela = new List<Jelo>();
        public static List<Prilog> prilozi = new List<Prilog>();
        public static List<Dodatak> dodaci = new List<Dodatak>();
        public static List<Rezervacija> rezervacije = new List<Rezervacija>();
        public static List<Restoran> restorani = new List<Restoran>();

        public LoginForm()
        {
            InitializeComponent();
            BinaryFormatter formater = new BinaryFormatter();

            //OVDE UCITAVAM SVE KORISNIKE IZ FAJLA
            ////////////////////////////////////////////////////////////////////////
            FileStream fs = new FileStream("korisnici.bin", FileMode.OpenOrCreate);
            while(fs.Position< fs.Length)
            {
                Korisnik korisnik = (Korisnik)formater.Deserialize(fs);
                korisnici.Add(korisnik);
            }
            fs.Dispose();
            if(korisnici.Count > 0)
                Korisnik.dodela_ID=korisnici[korisnici.Count-1].id;
            ////////////////////////////////////////////////////////////////////

            //JELA
            ////////////////////////////////////////////////////////////////////
            fs = new FileStream("jela.bin", FileMode.OpenOrCreate);
            while (fs.Position< fs.Length)
            {
                Jelo jelo = (Jelo)formater.Deserialize(fs);
                jela.Add(jelo);
            }
            fs.Dispose();
            if (jela.Count > 0)
                Jelo.dodela_ID=jela[jela.Count-1].id;
            ////////////////////////////////////////////////////////////////////

            //RESTORANI
            ///////////////////////////////////////////////////////////////////
            fs = new FileStream("restorani.bin", FileMode.OpenOrCreate);
            while (fs.Position< fs.Length)
            {
                Restoran restoran = (Restoran)formater.Deserialize(fs);
                restorani.Add(restoran);
            }
            fs.Dispose();
            if (restorani.Count > 0)
                Restoran.dodela_ID=jela[restorani.Count-1].id;
            //////////////////////////////////////////////////////////////////


            //PRILOZI
            //////////////////////////////////////////////////////////////////
            fs = new FileStream("prilozi.bin", FileMode.OpenOrCreate);
            while (fs.Position< fs.Length)
            {
                Prilog prilog = (Prilog)formater.Deserialize(fs);
                prilozi.Add(prilog);
            }
            fs.Dispose();
            if (prilozi.Count > 0)
                Prilog.dodela_ID=jela[restorani.Count-1].id;
            //////////////////////////////////////////////////////////////////

            //DODACI
            //////////////////////////////////////////////////////////////////
            fs = new FileStream("dodaci.bin", FileMode.OpenOrCreate);
            while (fs.Position< fs.Length)
            {
                Dodatak dodatak = (Dodatak)formater.Deserialize(fs);
                dodaci.Add(dodatak);
            }
            fs.Dispose();
            if (dodaci.Count > 0)
                Dodatak.dodela_ID=jela[restorani.Count-1].id;
            //////////////////////////////////////////////////////////////////

            //REZERVACIJE
            //////////////////////////////////////////////////////////////////
            fs = new FileStream("rezervacije.bin", FileMode.OpenOrCreate);
            while (fs.Position< fs.Length)
            {
                Rezervacija rezervacija = (Rezervacija)formater.Deserialize(fs);
                rezervacije.Add(rezervacija);
            }
            fs.Dispose();
            if (rezervacije.Count > 0)
                Rezervacija.dodela_ID=jela[restorani.Count-1].id;
            //////////////////////////////////////////////////////////////////


        }

        private void btnKreirajNalog_Click(object sender, EventArgs e)
        {
            NovNalogForm form = new NovNalogForm();
            form.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string usr = txtUsername.Text;
            string psw = txtPasswd.Text;
            bool uspesna_prijava = false;
            foreach(Korisnik korisnik in korisnici)
            {
                if(korisnik.Uspesna_prijava(usr, psw)==true)
                {
                    MessageBox.Show("Uspesna prijava!");
                    uspesna_prijava=true;
                    if(korisnik.Admin==true)
                    {
                        AdminForm frm = new AdminForm();
                        frm.Show();
                    }    
                    else
                    {
                        KlijentForm frm = new KlijentForm();
                        frm.Show();
                    }
                    break;
                }
            }
            if(uspesna_prijava==false)
                MessageBox.Show("NEUSPESNA PRIJAVA!!!");
        }


        //PRI ZATVARANJU POCETNE FORME CUVAM PODATKE KOJE SAM MENJAO U LISTI
        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //FileStream fs=new FileStream("korisnici.bin",FileMode.Open,FileAccess.Write);

        }
    }
}
