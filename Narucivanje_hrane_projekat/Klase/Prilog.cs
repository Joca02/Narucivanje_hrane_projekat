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
    public class Prilog
    {
        public static int dodela_ID;
        int ID;
        string naziv_priloga;
        double cena;
        bool showID = true;
        public bool ShowID { get => showID; set => showID=value; }

        public Prilog()
        {
            naziv_priloga="";
            cena=0.0;
        }
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

        public bool Sacuvaj_prilog()
        {
            foreach (Prilog prilog in LoginForm.prilozi)
            {
                if (prilog.naziv_priloga==naziv_priloga)
                {
                    return false;
                }
            }
            FileStream fs = new FileStream("prilozi.bin", FileMode.Append);
            BinaryFormatter formater = new BinaryFormatter();
            formater.Serialize(fs, this);
            LoginForm.prilozi.Add(this);
            fs.Close();
            return true;
        }
        public override string ToString()
        {
            if(showID==true)
                return "PrilogID "+ID+" "+naziv_priloga+" cena "+cena+"din";
            else
                return "Prilog "+naziv_priloga+" cena "+cena+"din";
        }
    }
}
