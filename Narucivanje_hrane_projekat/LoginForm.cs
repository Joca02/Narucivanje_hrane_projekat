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
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnKreirajNalog_Click(object sender, EventArgs e)
        {
            NovNalogForm form = new NovNalogForm();
            form.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(File.Exists(txtUsername.Text+".bin"))
            {
                FileStream fs = new FileStream(txtUsername.Text+".bin", FileMode.Open);
                BinaryFormatter formater=new BinaryFormatter();
                Korisnik nalog = (Korisnik)formater.Deserialize(fs);
                if(nalog.Uspesna_prijava(txtUsername.Text,txtPasswd.Text)==true)
                {
                    MessageBox.Show("Uspesna prijava!");
                }
                else
                {
                    MessageBox.Show("NEUSPESNA PRIJAVA!!!");
                }
                fs.Close();
            }
            else
                MessageBox.Show("Nalog sa unetim korisnickim imenom ne postoji!");

        }
    }
}
