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
        static int broj_clanova;
        int ID;
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
            broj_clanova++;
            ID=broj_clanova;
        }

        public string Korisnicko_ime { get => korisnicko_ime; set => korisnicko_ime=value; }
        public string Sifra { get => sifra; set => sifra=value; }
        public string Ime { get => ime; set => ime=value; }
        public string Prezime { get => prezime; set => prezime=value; }
        public bool Admin { get => admin; }     //skinuo sam set da ne bih mogao da menjam admin properti

        public bool Sacuvaj_nalog()
        {
            //AKO U LISTI VEC POSTOJI KORISNIK SA ISTIM IMENOM NE MOZE DA SE SACUVA NALOG
            foreach(Korisnik korisnik in LoginForm.korisnici)
            {
                if(korisnik.Korisnicko_ime==this.Korisnicko_ime)
                {
                    return false;
                }
            }

            //APDEJTUJEM LISTU IZ KOJE TRENUTNO PRATIM KORISNIKE KAO I BAZU KORISNICI.BIN
            FileStream fs=new FileStream("korisnici.bin", FileMode.Append);
            BinaryFormatter formater=new BinaryFormatter();
            formater.Serialize(fs, this);
            LoginForm.korisnici.Add(this);
            fs.Close();
            return true;   
        }

        public bool Uspesna_prijava(string usr,string psw)
        {
            return (usr==Korisnicko_ime && psw==Sifra);
        }
    }
}
