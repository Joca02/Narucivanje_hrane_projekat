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
        public LoginForm()
        {
            InitializeComponent();

            //OVDE UCITAVAM SVE KORISNIKE IZ FAJLA
            /////////////////////////////////////////////////////////////////////
            FileStream fs = new FileStream("korisnici.bin", FileMode.OpenOrCreate);
            BinaryFormatter formater = new BinaryFormatter();
            while(fs.Position< fs.Length)
            {
                Korisnik korisnik = (Korisnik)formater.Deserialize(fs);
                korisnici.Add(korisnik);
            }
            fs.Close();
            /////////////////////////////////////////////////////////////////////
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
