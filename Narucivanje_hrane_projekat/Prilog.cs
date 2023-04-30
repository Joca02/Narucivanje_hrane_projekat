using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Narucivanje_hrane_projekat
{
    [Serializable]
    public class Prilog
    {
        public static int dodela_ID;
        int ID;
        string naziv_priloga;
        double cena;

        public Prilog(string naziv_priloga, double cena)
        {
            this.Naziv_priloga=naziv_priloga;
            this.Cena=cena;
            dodela_ID++;
            ID=dodela_ID;
        }

        public string Naziv_priloga { get => naziv_priloga; set => naziv_priloga=value; }
        public double Cena { get => cena; set => cena=value; }
        public int id { get => ID;}
    }
}
