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
    public class Restoran
    {
        public static int dodela_ID;
        int ID;
        string naziv;
        string adresa;
        string kontakt_telefon;
        public Restoran()
        {
            adresa=naziv=kontakt_telefon="";
        }
        public Restoran(string naziv, string adresa, string kontakt_telefon)
        {
            this.naziv=naziv;
            this.adresa=adresa;
            this.kontakt_telefon=kontakt_telefon;
            dodela_ID++;
            ID=dodela_ID;
        }

        public string Naziv { get => naziv; set => naziv=value; }
        public string Adresa { get => adresa; set => adresa=value; }
        public string Kontakt_telefon { get => kontakt_telefon; set => kontakt_telefon=value; }
        public int id { get => ID;}

        public bool Sacuvaj_restoran()
        {
            foreach (Restoran restoran in LoginForm.restorani)
            {
                if (restoran.adresa==adresa || restoran.naziv==naziv||restoran.kontakt_telefon==kontakt_telefon)
                {
                    return false;
                }
            }
            FileStream fs = new FileStream("restorani.bin", FileMode.Append);
            BinaryFormatter formater = new BinaryFormatter();
            formater.Serialize(fs, this);
            LoginForm.restorani.Add(this);
            fs.Close();
            return true;
        }
        public override string ToString()
        {
            return "RestoranID "+ID+" "+naziv+" "+adresa+" "+kontakt_telefon;
        }
    }
}
