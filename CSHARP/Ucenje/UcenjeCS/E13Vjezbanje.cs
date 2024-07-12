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
            #region zadaci za PodaciInt
            //Zadatak1();
            //Zadatak2();
            //Zadatak3();
            //Zadatak4();
            //Zadatak5();
            //Zadatak6();
            //Zadatak7();
            //zadatak8();
            //zadatak9();
            #endregion

        }



        #region PodaciInt metode
        private static void Zadatak1()
        {
            // Postoji li dva ista broja? Ako postoji koji je to broj?
            var niz = PodaciInt.niz;

            Array.Sort(niz);

            for (int i = 0; i < niz.Length; i++)
            {
                if (niz[i] == niz[i + 1])
                {
                    Console.WriteLine(niz[i]);
                    break;
                }
            }

        }

        private static void Zadatak2()
        {
            // Koji je najveći broj?
            var niz = PodaciInt.niz;

            Array.Sort(niz);

            Console.WriteLine("Najveći broj je {0}", niz[niz.Length - 1]);
        }

        private static void Zadatak3()
        {
            // Koji je najmanji broj?
            var niz = PodaciInt.niz;

            Array.Sort(niz);

            Console.WriteLine("Najmanji broj je {0}", niz[0]);
        }

        private static void Zadatak4()
        {
            // Koliko je parnih brojeva?
            var niz = PodaciInt.niz;
            int count = 0;

            for (int i = 0; i < niz.Length; i++)
            {
                if (niz[i] % 2 == 0)
                {
                    count++;
                }
            }

            Console.WriteLine("U nizu se nalazi {0} parnih brojeva.", count);

        }

        private static void Zadatak5()
        {
            // Koliko je neparnih brojeva?
            var niz = PodaciInt.niz;
            int count = 0;

            for (int i = 0; i < niz.Length; i++)
            {
                if (niz[i] % 2 != 0)
                {
                    count++;
                }
            }
            Console.WriteLine("U nizu se nalazi {0} neparnih brojeva.", count);
        }

        private static void Zadatak6()
        {
            // Koliko je prim brojeva?
            var niz = PodaciInt.niz;
            int count = 0;

            for (int i = 0; i < niz.Length; i++)
            {
                if (prim(niz[i]))
                {
                    count++;
                }
            }
            Console.WriteLine("U nizu se nalazi {0} prim brojeva.", count);
        }

        private static bool prim(int broj)
        {
            for (int i = 2; i < broj; i++)
            {
                if (broj % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        private static void Zadatak7()
        {
            // Koji je najveći prim broj?
            var niz = PodaciInt.niz;
            int maxPrime = 0;

            for (int i = 0; i < niz.Length; i++)
            {
                if (prim(niz[i]))
                {
                    if (niz[i] > maxPrime)
                    {
                        maxPrime = niz[i];
                    }
                }
            }
            Console.WriteLine("Najveći prim broj je: {0}", maxPrime);
        }

        private static void zadatak8()
        {
            // Koliko je brojeva koji u sebi imaju znamenku 7?
            var niz = PodaciInt.niz;
            int count = 0;
            string broj;

            for (int i = 0; i < niz.Length; i++)
            {
                broj = niz[i].ToString();
                foreach (char b in broj)
                {
                    if (b == '7')
                    {
                        count++;
                        break;
                    }
                }
            }
            Console.WriteLine("U nizu ima {0} brojeva koji imaju znamenku 7", count);
            Console.WriteLine("Od ukupno {0} brojeva", niz.Length);
        }

        private static void zadatak9()
        {
            // Koliko je brojeva koji u sebi nemaju znamenku 7?
            var niz = PodaciInt.niz;
            int count = 0, sedmice = 0;
            string broj;

            for (int i = 0; i < niz.Length; i++)
            {
                broj = niz[i].ToString();
                foreach(char b in broj)
                {
                    if(b == '7')
                    {
                        sedmice++;
                        break;
                    }
                }
                if(sedmice == 0)
                {
                    count++;
                }
                else
                {
                    sedmice = 0;
                }
            }
            Console.WriteLine("U nizu se nalazi {0} brojeva koji nemaju znamenku 7", count);
            Console.WriteLine("Od ukupno {0} brojeva", niz.Length);
        }
        #endregion
    }
}
