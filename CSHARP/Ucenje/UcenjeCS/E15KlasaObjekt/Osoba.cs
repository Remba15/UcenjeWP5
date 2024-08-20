using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.E15KlasaObjekt
{
    //Klasa je opisnik objekta
    internal class Osoba
    {

        //Klasa sadrži svojstva (property)
        public int? Sifra { get; set; }
        public string? Ime { get; set; } // ? oznacava da ime moze biti null
        public string? Prezime { get; set; }

        public Mjesto? Mjesto { get; set; }


        public string ImePrezime()
        {
            return Ime + " " + Prezime;
        }




        //Klasa sadrži metode

    }
}
