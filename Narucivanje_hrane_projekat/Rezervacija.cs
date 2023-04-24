using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Narucivanje_hrane_projekat
{
    public class Rezervacija
    {
        static int broj_clanova;
        int ID;
        int ID_korisnik;
        List<Jelo> porucena_jela;
        double ukupna_cena;
        string sifra;//nz sta sa ovim da radim

        public Rezervacija(int iD_korisnik)
        {
            Porucena_jela = new List<Jelo>();
            ID_korisnik=iD_korisnik;
        }

        public List<Jelo> Porucena_jela { get => porucena_jela; set => porucena_jela=value; }
        public double Ukupna_cena { get => ukupna_cena; set => ukupna_cena=value; }
        public string Sifra { get => sifra; set => sifra=value; }
    }
}
