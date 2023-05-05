﻿using System;
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
    public partial class RezervacijaForm : Form
    {
        static public int id_restorana;
        public static Rezervacija rezervacija;
        public RezervacijaForm(int id_korisnika)
        {
            InitializeComponent();
            rezervacija = new Rezervacija(id_korisnika);
            pnl.Hide();
        }

        List<Jelo> jela;
        void Osvezi()
        {
            jela = new List<Jelo>();
            
            foreach(Jelo jelo in LoginForm.jela)
            {
                if (jelo.ID_Restoran==id_restorana)
                    jela.Add(jelo);
            }
            lbJela.DataSource=null;
            lbJela.DataSource=jela;

            lbRezJela.DataSource=null;
            lbRezJela.DataSource=rezervacija.Porucena_jela;
            if (AdminForm.pOsvezi!=null)
                AdminForm.pOsvezi-=Osvezi;

        }
        private void btnIzaberiRestoran_Click(object sender, EventArgs e)
        {
            KlijentRestoranForm f=new KlijentRestoranForm(txtRestoran);
            f.Show();
            AdminForm.pOsvezi+=Osvezi;
            pnl.Show();
        }

        private void lbJela_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = lbJela.SelectedIndex;
            if(index!=-1)
            {
                PorucivanjeJelaForm f = new PorucivanjeJelaForm(jela[index]);
                AdminForm.pOsvezi+=Osvezi;
                f.Show();
            }
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (lbRezJela.Items.Count==0)
                MessageBox.Show("Morate uneti bar 1 jelo za validnu rezervaciju!");
            else
            {
                foreach(Jelo sva_jela in jela)
                {
                    foreach(Jelo j in rezervacija.Porucena_jela)
                    {
                        if (sva_jela.id==j.id)
                            rezervacija.Ukupna_cena+=j.Cena;
                    }
                        
                }
                
                LoginForm.rezervacije.Add(rezervacija);
                MessageBox.Show("Uspesno ste dodali rezervaciju!");
                KlijentForm.osvezi();
                this.Close();
            }
        }
    }
}
