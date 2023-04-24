using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Narucivanje_hrane_projekat
{
    public class Prilog
    {
        static int broj_clanova;
        int ID;
        string naziv_priloga;
        double cena;

        public Prilog(string naziv_priloga, double cena)
        {
            this.Naziv_priloga=naziv_priloga;
            this.Cena=cena;
            broj_clanova++;
            ID=broj_clanova;
        }

        public string Naziv_priloga { get => naziv_priloga; set => naziv_priloga=value; }
        public double Cena { get => cena; set => cena=value; }
    }
}
