using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Narucivanje_hrane_projekat
{
    [Serializable]
    public class Jelo
    {
        public static int dodela_ID;
        int ID;
        string naziv;
        double gramaza;
        string opis;
        double cena;
        int ID_prilog;
        int ID_restoran;
        bool prilog_obavezan = false;
        List<Dodatak> dodaci;

        public Jelo(string naziv, double gramaza, string opis, double cena, int iD_prilog, int iD_restoran)
        {
            dodaci = new List<Dodatak>();
            this.Naziv=naziv;
            this.Gramaza=gramaza;
            this.Opis=opis;
            this.Cena=cena;
            ID_prilog1=iD_prilog;
            ID_restoran1=iD_restoran;
            dodela_ID++;
            ID=dodela_ID;
        }

        public string Naziv { get => naziv; set => naziv=value; }
        public double Gramaza { get => gramaza; set => gramaza=value; }
        public string Opis { get => opis; set => opis=value; }
        public double Cena { get => cena; set => cena=value; }
        public int ID_prilog1 { get => ID_prilog; set => ID_prilog=value; }
        public int ID_restoran1 { get => ID_restoran; set => ID_restoran=value; }
        public bool Prilog_obavezan { get => prilog_obavezan; set => prilog_obavezan=value; }
        public int id { get => ID; }
    }
}
