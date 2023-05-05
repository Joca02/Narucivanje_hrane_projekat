using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Narucivanje_hrane_projekat
{
    [Serializable]
    public class Dodatak
    {
        public static int dodela_ID;
        int ID;
        string naziv_dodatka;
        double cena;
        double gramaza;
        bool showID = true;
        public bool ShowID { get => showID; set => showID=value; }

        public Dodatak()
        {
            naziv_dodatka="";
            cena=gramaza=0.0;
        }

        public Dodatak(string naziv_dodatka, double cena, double gramaza)
        {
            this.Naziv_dodatka=naziv_dodatka;
            this.Cena=cena;
            this.Gramaza=gramaza;
            dodela_ID++;
            ID=dodela_ID;
        }

        public string Naziv_dodatka { get => naziv_dodatka; set => naziv_dodatka=value; }
        public double Cena { get => cena; set => cena=value; }
        public double Gramaza { get => gramaza; set => gramaza=value; }
        public int id { get => ID; }

        public bool Sacuvaj_dodatak()
        {
            foreach (Dodatak dodatak in LoginForm.dodaci)
            {
                if (dodatak.naziv_dodatka==naziv_dodatka)
                {
                    return false;
                }
            }
            FileStream fs = new FileStream("dodaci.bin", FileMode.Append);
            BinaryFormatter formater = new BinaryFormatter();
            formater.Serialize(fs, this);
            LoginForm.dodaci.Add(this);
            fs.Close();
            return true;
        }

        public override string ToString()
        {
            if(showID==true)
                return "DodatakID "+ID+" "+naziv_dodatka+" cena "+cena+"din "+gramaza+"g";
            else
                return "Dodatak "+naziv_dodatka+" cena "+cena+"din "+gramaza+"g";
        }
    }
}
