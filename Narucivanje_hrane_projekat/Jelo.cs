using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Narucivanje_hrane_projekat
{
    [Serializable]
    public class Jelo
    {
        public static int dodela_ID;
        int ID;
        string naziv;
        double gramaza;
        string opis="Nema opisa za ovo jelo.";
        double cena;
        int ID_prilog=-1;
        int ID_restoran=-1;
        bool prilog_obavezan = false;
        public List<int> id_dodaci = new List<int>();
        bool showID=true;
        public bool ShowID { get => showID; set => showID=value; }


        public Jelo ()
        {
            naziv=opis="";
            cena=gramaza=0.0;
        }
        public Jelo(Jelo j)
        {
            this.naziv = j.naziv;
            this.gramaza = j.gramaza;
            this.opis = j.opis;
            this.cena = j.cena;
            this.ID = j.ID;
            this.ID_prilog = j.ID_prilog;
            this.ID_restoran = j.ID_restoran;
            this.prilog_obavezan = j.prilog_obavezan;
            this.id_dodaci = new List<int>(j.id_dodaci);
            this.showID = j.showID;
        }
        public Jelo(string naziv,  double cena,double gramaza, string opis,int ID_restoran)
        {
            
            this.Naziv=naziv;
            this.Gramaza=gramaza;
            this.Opis=opis;
            this.Cena=cena;
            this.ID_restoran=ID_restoran;
            dodela_ID++;
            ID=dodela_ID;
        }

        public string Naziv { get => naziv; set => naziv=value; }
        public double Gramaza { get => gramaza; set => gramaza=value; }
        public string Opis { get => opis; set => opis=value; }
        public double Cena { get => cena; set => cena=value; }
        public int ID_Prilog { get => ID_prilog; set => ID_prilog=value; }
        public int ID_Restoran { get => ID_restoran; set => ID_restoran=value; }
        public bool Prilog_obavezan { get => prilog_obavezan; set => prilog_obavezan=value; }
        public int id { get => ID; }

        public bool Sacuvaj_jelo()
        {
            foreach (Jelo jelo in LoginForm.jela)
            {
                if (jelo.naziv==naziv && jelo.ID_restoran==ID_restoran)
                {
                    return false;
                }
            }
            FileStream fs = new FileStream("jela.bin", FileMode.Append);
            BinaryFormatter formater = new BinaryFormatter();
            formater.Serialize(fs, this);
            LoginForm.jela.Add(this);
            fs.Close();
            return true;
        }
        public override string ToString()
        {
            foreach(Restoran r in LoginForm.restorani)
            {
                if(r.id==ID_Restoran)
                {
                    if(showID==true)
                        return "JeloID "+ID+" "+naziv +" cena "+cena+"din  gramaza: "+gramaza+"g"+" Restoran: "+r.Naziv;
                    else
                        return "Jelo "+naziv +" cena "+cena+"din   gramaza: "+gramaza+"g"+" Restoran: "+r.Naziv;
                }
                    
            }
            return " ";
        }
    }
}
