using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Narucivanje_hrane_projekat
{
    [Serializable]
    public class Rezervacija
    {
        public static int dodela_ID;
        int ID;
        int ID_korisnik;
        List<Jelo> porucena_jela;
        double ukupna_cena;
        public DateTime date;
        bool showID=false;
        public bool ShowID { get => showID; set => showID=value; }
        public Rezervacija(int iD_korisnik)
        {
            Porucena_jela = new List<Jelo>();
            ID_korisnik=iD_korisnik;
            dodela_ID++;
            ID = dodela_ID;
            date = DateTime.Today;
        }

        public List<Jelo> Porucena_jela { get => porucena_jela; set => porucena_jela=value; }
        public double Ukupna_cena { get => ukupna_cena; set => ukupna_cena=value; }
        public int id { get => ID;  }
        public int ID_Korisnik { get => ID_korisnik; set => ID_korisnik=value; }

        public override string ToString()
        {
            string s = "";
            foreach (Jelo j in porucena_jela)
                s+=j.Naziv+" ";
            if(showID==true)
                return "ID Rezervacije "+ID+" - {"+s+ "} \n Ukupna cena: "+ukupna_cena+"\n Datum "+date;

            return "Jela {" + s +"} \n Ukupna cena: "+ukupna_cena+"\n Datum "+date;
        }
    }
}
