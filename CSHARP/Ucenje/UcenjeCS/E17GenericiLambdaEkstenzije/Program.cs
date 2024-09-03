using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.E17GenericiLambdaEkstenzije
{
    internal class Program
    {

        public Program()
        {
            //glavni problem rada s nizovima: Ograničeni s inicijalnim brojem elemenata


            //Rješenje: Koristiti generičke klase
            //Klasa List je parametrizirana (TIPA) tipom podatka int i u integeri varijalu mogu ici samo cijeli brojevi.
            List<int> integeri = new List<int>();

            integeri.Add(1);
            integeri.Add(21);
            //integeri.Add("2"); NE MOZE

            Console.WriteLine(integeri[0]);

            List<string> gradovi = new List<string>();

            gradovi.Add("Osijek");
            gradovi.Add("Valpovo");

            Console.WriteLine(gradovi[1]);

            //Ovo je korištenje generika
            List<Smjer> smjerovi = new List<Smjer>();

            smjerovi.Add(new Smjer() { Sifra = 11, Naziv = "WP" });

            smjerovi.Add(new() { Sifra = 7, Naziv = "RR" });

            smjerovi.Add(new() { Sifra = 9, Naziv = "AA" });


            //Zadatak iz liste smjerova ispisati broj 7
            Console.WriteLine(smjerovi[1].Sifra);


            //Obrada<string> p = new Obrada<string>(); // string ne nasljeđuje entitet pa neide

            Obrada<Smjer> o1 = new Obrada<Smjer>();

            o1.ObjektObrade = new Smjer() { Sifra = 1, Naziv = "WP" };

            Obrada<Polaznik> o2 = new Obrada<Polaznik>();

            o2.ObjektObrade = new() { Sifra = 2, Ime = "Pero", Prezime = "Perić" };

            o1.Obradi();
            o2.Obradi();

            //Zadatak: Kreirajte listu datuma i u nju dodajte 2 datuma
            // 1. je datum Vašeg rođenja, a 2. današnji datum

            List<DateTime> datumi = new List<DateTime>();
            datumi.Add(new DateTime(1996, 5, 29));
            datumi.Add(DateTime.Now);

            foreach (DateTime dt in datumi)
            {
                Console.WriteLine(dt);
            }

            //lambda izrazi
            Console.WriteLine(KlasicnaMetoda(2, 3));

            var Zbroj = (int x, int y) => x + y;

            Console.WriteLine(Zbroj(2, 3));

            var Algoritam = (int x, int y) =>
            {
                var t = x + 1;

                return t - y;
            };

            Console.WriteLine(Algoritam(2, 3));


            //Zadatak: Kreirajte lambda izraz koji za primljeni broj vraća da li je parni ili ne (bool)

            var JeParan = (int x) => x % 2 == 0;

            Console.WriteLine(JeParan(2));
            Console.WriteLine(JeParan(3));

            //ekstenzije
            var s = "Osijek";
            Console.WriteLine(s.LastOrDefault());

            Console.WriteLine(gradovi.LastOrDefault());

            Console.WriteLine(smjerovi.LastOrDefault());

            smjerovi[0].OdradiPosao();

            o2.ObjektObrade.OdradiPosao();


            o1.PrikazRadaSSuceljem();
            smjerovi[0].PrikazRadaSSuceljem();
            o2.ObjektObrade.PrikazRadaSSuceljem();

            smjerovi.Sort();
            Console.WriteLine(smjerovi.FirstOrDefault()?.Sifra);

            //Custom sort bez korištenja implementacije sučelja IComparable
            smjerovi.Sort((s1,s2) => s1.Naziv.CompareTo(s2.Naziv));

            Console.WriteLine(smjerovi.FirstOrDefault()?.Naziv);

            o1.ListaZaObradu = smjerovi;
            o1.IspisStavaka(TuMeObradi);

            o1.IspisStavaka(s =>
            {
                Console.WriteLine("I bez poziva metode " + s.Naziv);
            });
        }

        public void TuMeObradi(Smjer s)
        {
            Console.WriteLine("Obrađujem u Programu smjer s pozivom metode " + s.Naziv);
        }

        //DZ NA REPOZITORIJU OD PROFE


        public int KlasicnaMetoda(int x, int y)
        {
            return x + y;
        }

        }
    }
