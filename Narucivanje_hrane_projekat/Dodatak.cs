using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Narucivanje_hrane_projekat
{
    public class Dodatak
    {
        static int broj_clanova;
        int ID;
        string naziv_dodatka;
        double cena;
        double gramaza;

        public Dodatak(string naziv_dodatka, double cena, double gramaza)
        {
            this.Naziv_dodatka=naziv_dodatka;
            this.Cena=cena;
            this.Gramaza=gramaza;
            broj_clanova++;
            ID=broj_clanova;
        }

        public string Naziv_dodatka { get => naziv_dodatka; set => naziv_dodatka=value; }
        public double Cena { get => cena; set => cena=value; }
        public double Gramaza { get => gramaza; set => gramaza=value; }
    }
}
