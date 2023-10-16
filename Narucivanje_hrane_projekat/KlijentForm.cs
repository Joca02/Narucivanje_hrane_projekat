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
    public partial class KlijentForm : Form
    {
        public static AdminForm.Osvezi osvezi;
        public Korisnik klijent;
        DateTime min;
        DateTime max;
        public KlijentForm(Korisnik korisnik)    
        {
            InitializeComponent();
            klijent=korisnik;
            Postavi_Rezervacije();

            if (moje_rezervacije.Count!=0)
            {
                min =moje_rezervacije[0].date.Date;
                max = moje_rezervacije[0].date.Date;
                foreach (Rezervacija rezervacija in moje_rezervacije)
                {
                    if (rezervacija.date>max)
                        max=rezervacija.date;
                    else if (rezervacija.date<min)
                        min=rezervacija.date;
                }

                dtMin.MinDate=min;
                dtMin.MaxDate=max;
                dtMax.MaxDate=max;
                dtMax.MinDate=min;
                dtMin.Value=min;
                dtMax.Value=max;
            }

        }
        List<Rezervacija> moje_rezervacije;
        void Postavi_Rezervacije()
        {
            moje_rezervacije=new List<Rezervacija>();
            foreach(Rezervacija rezervacija in LoginForm.rezervacije)
            {
                if(rezervacija.ID_Korisnik==klijent.id)
                { 
                    moje_rezervacije.Add(rezervacija);
                }
                    
            }
            lbRezervacije.DataSource=null;
            lbRezervacije.DataSource=moje_rezervacije;

            if (AdminForm.pOsvezi!=null)
                AdminForm.pOsvezi-=Postavi_Rezervacije;
        }

        void Filtriraj_datum(DateTime min,DateTime max)
        {
            List<Rezervacija> kopija = new List<Rezervacija>();
            foreach (Rezervacija rezervacija in moje_rezervacije)
            {
                if (rezervacija.date.Date >= min.Date && rezervacija.date.Date <= max.Date)
                    kopija.Add(rezervacija);
            }
            lbRezervacije.DataSource = null;
            lbRezervacije.DataSource = kopija;
        }


        private void btnDodajRezervaciju_Click(object sender, EventArgs e)
        {
            RezervacijaForm f = new RezervacijaForm(klijent.id);
           osvezi+=Postavi_Rezervacije;
            f.Show();
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            Filtriraj_datum(dtMin.Value,dtMax.Value);
        }

        private void dtMax_ValueChanged(object sender, EventArgs e)
        {
            Filtriraj_datum(dtMin.Value, dtMax.Value);
        }

        private void lbRezervacije_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show(lbRezervacije.SelectedItem.ToString());
        }
    }
}
