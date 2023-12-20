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
        public static int dodela_ID;
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
            dodela_ID++;
            ID=dodela_ID;
        }

        public string Korisnicko_ime { get => korisnicko_ime; set => korisnicko_ime=value; }
        public string Sifra { get => sifra; set => sifra=value; }
        public string Ime { get => ime; set => ime=value; }
        public string Prezime { get => prezime; set => prezime=value; }
        public bool Admin { get => admin; set => admin=value; }     //skinuo sam set da ne bih mogao da menjam admin properti
        public int id { get => ID; }

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

        public override string ToString()
        {
            if(admin==true)
                return " ID: "+ID+
                    "\n Korisnicko ime: "+korisnicko_ime+
                    "\n Ime: "+ime+
                    "\n Prezime"+prezime+
                    "\n Admin: jeste"+
                    "\n Lozinka: nije dostupna!" ;
            else
                return " ID: "+ID+
                   "\n Korisnicko ime: "+korisnicko_ime+
                   "\n Ime: "+ime+
                   "\n Prezime"+prezime+
                   "\n Admin: nije"+
                   "\n Lozinka: "+sifra;
        }
    }
}
