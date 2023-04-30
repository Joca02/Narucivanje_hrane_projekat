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

        public Rezervacija(int iD_korisnik)
        {
            Porucena_jela = new List<Jelo>();
            ID_korisnik=iD_korisnik;
            dodela_ID++;
            ID = dodela_ID;
        }

        public List<Jelo> Porucena_jela { get => porucena_jela; set => porucena_jela=value; }
        public double Ukupna_cena { get => ukupna_cena; set => ukupna_cena=value; }
        public int id { get => ID;  }
    }
}
