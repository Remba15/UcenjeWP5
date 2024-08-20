using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using UcenjeCS.E15KlasaObjekt.Edunova;

namespace UcenjeCS.E15KlasaObjekt
{
    internal class Program
    {
        public static void Izvedi()
        {
            Console.WriteLine("Hello OOP");

            //Objekt je instanca (pojavnost) klase

            //Osoba je ime klase
            //osoba je ime objekta (instance/pojavnosti) - varijabla

            Osoba osoba; //Deklariranje bez instance
            osoba = new Osoba(); //Konstruiranje objekta

            osoba.Ime = "Pero";
            osoba.Prezime = "Perić";

            Console.WriteLine(osoba.ImePrezime());

            //Drugi načini kreiranja objekta

            Osoba ravnatelj = new Osoba
            {
                Sifra = 1,
                Ime = "Marko",
                Prezime = "Kas"
            };

            var direktor = new Osoba { Ime = "Edo" }; //Dobra praksa

            Osoba profesor = new() { Prezime = "Reh", Ime = "Klara"};

            Console.WriteLine(profesor.Ime?.ToUpper());

            var o = new Osoba()
            {
                Ime = "Marija",
                Mjesto = new() { Naziv = "Osijek", PostanskiBroj = "31000" }
            };

            Console.WriteLine(o.Mjesto?.Naziv?.ToUpper());


            //Dugi način

            Zupanija obz = new Zupanija();
            obz.Naziv = "Osječko-Baranjska Županija";

            Mjesto os = new Mjesto();
            os.Zupanija = obz;

            Osoba ja = new Osoba();
            ja.Ime = "Renato";
            ja.Mjesto = os;

            //Ispišite u konzoli iz objekta o vrijednost Osječko-Baranjska Županija

            Console.WriteLine(ja.Mjesto?.Zupanija?.Naziv);

            //Objekti iz edunova klasa

            var smjer = new Smjer() { Sifra = E11Metode.UcitajCijeliBroj("Unesi sifru", 1, 10000), Naziv = "Web" };

            var grupa = new Grupa() { Naziv = "WP5", Smjer = smjer };

            //zadatak Ispiši Šifru smjera na grupi WP5

            Console.WriteLine(grupa.Smjer.Sifra);

        }

    }
}
