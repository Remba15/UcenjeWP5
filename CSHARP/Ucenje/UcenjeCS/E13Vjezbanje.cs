using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E13Vjezbanje
    {
        public static void Izvedi()
        {
            //Zadatak1();
            //Zadatak2();
            //Zadatak3();
            //Zadatak4();
            //Zadatak5();
            Zadatak6();


        }

        private static void Zadatak6()
        {

            //Koliko elemenata niza ima zapis u 7 sekundi.
            foreach(var d in PodaciDateTime.Niz())
            {
                if (d.Second == 7)
                {
                    Console.WriteLine(d.ToString("yyyy-MM-dd HH:mm:ss"));
                }
            }

        }

        private static void Zadatak5()
        {
            //Ispisati sva imena koja se sastoje od dva imena

            var imena = PodaciString.Niz;

            foreach(var ime in imena)
            {
                if (ime.Contains('-'))
                {
                    Console.WriteLine(ime);
                }
            }


        }

        private static void Zadatak4()
        {
            int cijeliBroj;
            for(int i = 0; i < PodaciFloat.Niz.Length; i++)
            {
                var b = PodaciFloat.Niz[i];
                cijeliBroj = (int)b;
                if(b-cijeliBroj == 0)
                {
                    Console.WriteLine(b);
                }
            }

        }

        private static void Zadatak3()
        {
            //Koliko je prim (prostih) (eng. prime) brojeva
            int ukupno = 0;
            for (int i = 0; i < PodaciInt.niz.Length; i++)
            {
                if (prim(PodaciInt.niz[i]))
                {
                    ukupno++;
                }
            }
            Console.WriteLine(ukupno);
        }

        private static bool prim(int broj)
        {

            for (int i = 2; i < broj; i++)
            {
                if (broj == 0)
                {
                    return false;
                }
            }

            return true;
        }

        private static void Zadatak2()
        {
            var niz = PodaciInt.niz;
            Array.Sort(niz);
            Console.WriteLine(niz.Length - 1);
        }

        private static void Zadatak1()
        {

            //Koliko elemenata ima niz int brojeva
            Console.WriteLine(PodaciInt.niz.Length);

            //Postoji li dva ista broja? Ako postoji koji je to broj?
            var niz = PodaciInt.niz;

            DateTime pocetak = DateTime.Now;

            /*
            for (int i = 0; i < niz.Length; i++)
            {
                if(i % 1000 == 0)
                {
                    Console.WriteLine(i);
                }
                for (int j = i + 1; j < niz.Length; j++)
                {
                    if (niz[j] == niz[i])
                    {
                        Console.WriteLine(niz[j]);
                        goto labela;
                    }
                }
            }
            labela:
            Console.WriteLine("Trajalo {0}", DateTime.Now - pocetak);
            */
            //Ovaj kod je trajao 3 i nest minute

            Array.Sort(niz);
            for (int i = 0; i < niz.Length; i++)
            {
                if (niz[i] == niz[i + 1])
                {
                    Console.WriteLine(niz[i]);
                    break;
                }
            }
            Console.WriteLine("Trajalo {0} ms", (DateTime.Now - pocetak).Milliseconds);
        }
    }
}
