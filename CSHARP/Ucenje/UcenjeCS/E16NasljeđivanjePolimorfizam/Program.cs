using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.E16NasljeđivanjePolimorfizam
{
    internal class Program
    {
        public Program()
        {
            Console.WriteLine("Hello from constructor");
            var s = new Smjer();
            s.Sifra = 2;
            s.Naziv = "WP";

            Console.WriteLine(s.Sifra);
            Console.WriteLine(s.Naziv);

            Console.WriteLine(s.GetHashCode());

            var s1 = new Smjer();

            s1.Sifra = 2;
            s1.Naziv = "WP";

            Console.WriteLine(s1.GetHashCode());

            //String je imutable - nepromjenjiv
            var a = "A";
            Console.WriteLine(a.GetHashCode());

            a = a + "B";
            Console.WriteLine(a.GetHashCode());

            StringBuilder sb = new StringBuilder();
            sb.Append('A');
            Console.WriteLine(sb.GetHashCode());
            sb.Append('B');
            Console.WriteLine(sb.GetHashCode());
            Console.WriteLine(sb);


            Console.WriteLine(s.ToString()); //Ovako ne treba
            Console.WriteLine(s); // i ovako se poziva toString metoda

            var g = new Grupa() { Sifra = 1, DatumPocetka = DateTime.Now };
            Console.WriteLine(g);


            var polaznik = new Polaznik();
            polaznik.Sifra = 1;
            polaznik.Ime = "Pero";

            var predavac = new Predavac() { Sifra = 1, Ime = "Marko" };

            Console.WriteLine("{0} - {1}", polaznik, predavac);


            //var e = new Entitet(); - apstraktna klasa se ne može instancirati
            



            var obradi = new Obrada[2];

            obradi[0] = new ObradaIzlaznihRacuna();
            obradi[1] = new ObradaUlaznihRacuna();

            // Polimorfizam
            foreach (var o in obradi)
            {
                o.Procesuiraj();
            }

        }

        //overload konstruktora
        public Program(string s)
        {
            Console.WriteLine("Hello from constructor " + s);


        }

    }
}
