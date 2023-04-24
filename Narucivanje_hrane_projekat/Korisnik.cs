using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
namespace Narucivanje_hrane_projekat
{
    [Serializable]
    public class Korisnik
    {
        static int ID;
        string korisnicko_ime;
        string sifra;
        string ime;
        string prezime;
        bool admin;


        public Korisnik(string korisnicko_ime, string sifra, string ime, string prezime, bool admin)
        {
            this.Korisnicko_ime=korisnicko_ime;
            this.Sifra=sifra;
            this.Ime=ime;
            this.Prezime=prezime;
            this.admin=admin;
            ID++;
        }

        public string Korisnicko_ime { get => korisnicko_ime; set => korisnicko_ime=value; }
        public string Sifra { get => sifra; set => sifra=value; }
        public string Ime { get => ime; set => ime=value; }
        public string Prezime { get => prezime; set => prezime=value; }
        public bool Admin { get => admin; }     //skinuo sam set da ne bih mogao da menjam admin properti

        public bool Sacuvaj_nalog()
        {
            if (File.Exists(Korisnicko_ime+".bin"))
                return false;
            FileStream fs=new FileStream(this.Korisnicko_ime+".bin", FileMode.Create);
            BinaryFormatter formater=new BinaryFormatter();
            formater.Serialize(fs, this);
            fs.Close();
            return true;   
        }

        public bool Uspesna_prijava(string usr,string psw)
        {
            return (usr==Korisnicko_ime && psw==Sifra);
        }
    }
}
