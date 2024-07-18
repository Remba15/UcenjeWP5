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
            #region Zadaci za PodaciInt
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

            #region Zadaci za PodaciFloat
            //Zadatak10();
            //Zadatak11();
            //Zadatak12();
            //Zadatak13();
            //Zadatak14();
            //Zadatak15();
            //Zadatak16();
            //Zadatak17();
            #endregion

            #region Zadaci za PodaciString
            //Zadatak18();
            //Zadatak19();
            //Zadatak20();
            //Zadatak21();
            //Zadatak22();
            //Zadatak23();
            #endregion

            #region Zadaci za PodaciDateTime
            //Zadatak24();
            //Zadatak25();
            //Zadatak26();
            //Zadatak27();
            //Zadatak28();
            //Zadatak29();
            //Zadatak30();
            #endregion

        }


        #region Metode za PodaciInt

        /// <summary>
        /// Metoda provjerava da li postoje dva ista broja u nizu PodaciInt. Ukoliko postoje isti brojevi, oni se ispisuju.
        /// </summary>
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

        /// <summary>
        /// Metoda ispisuje najveći broj u nizu PodaciInt.
        /// </summary>
        private static void Zadatak2()
        {
            // Koji je najveći broj?
            var niz = PodaciInt.niz;

            Array.Sort(niz);

            Console.WriteLine("Najveći broj je {0}", niz[niz.Length - 1]);
        }

        /// <summary>
        /// Metoda ispisuje najmanji broj u nizu PodaciInt.
        /// </summary>
        private static void Zadatak3()
        {
            // Koji je najmanji broj?
            var niz = PodaciInt.niz;

            Array.Sort(niz);

            Console.WriteLine("Najmanji broj je {0}", niz[0]);
        }

        /// <summary>
        /// Metoda ispisuje koliko se parnih brojeva nalazi u nizu PodaciInt
        /// </summary>
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

        /// <summary>
        /// Metoda ispisuje koliko se neparnih brojeva nalazi u nizu PodaciInt.
        /// </summary>
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

        /// <summary>
        /// Metoda ispisuje koliko se prostih brojeva nalazi u nizu PodaciInt.
        /// </summary>
        private static void Zadatak6()
        {
            // Koliko je prim brojeva?
            var niz = PodaciInt.niz;
            int count = 0;

            for (int i = 0; i < niz.Length; i++)
            {
                if (Prim(niz[i]))
                {
                    count++;
                }
            }
            Console.WriteLine("U nizu se nalazi {0} prim brojeva.", count);
        }

        /// <summary>
        /// Metoda provjerava da li je uneseni broj prosti broj.
        /// </summary>
        /// <param name="broj"></param>
        /// <returns>
        /// Bool vrijednost koja označava da li je primljeni broj prosti ili nije.
        /// </returns>
        private static bool Prim(int broj)
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
                if (Prim(niz[i]))
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
                foreach (char b in broj)
                {
                    if (b == '7')
                    {
                        sedmice++;
                        break;
                    }
                }
                if (sedmice == 0)
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



        #region Metode za PodaciFloat


        private static void Zadatak10()
        {
            // Koliko ima brojeva u nizu?

            Console.WriteLine("U nizu ima {0} elemenata.", PodaciFloat.Niz.Length);
        }

        private static void Zadatak11()
        {
            // Koliko je brojeva manje od 10
            var niz = PodaciFloat.Niz;
            int count = 0;

            foreach (var n in niz)
            {
                if (n < 10)
                {
                    count++;
                }
            }

            Console.WriteLine("U nizu se nalazi {0} brojeva koji su manji od 10.", count);

        }

        private static void Zadatak12()
        {
            // Ispišite najveći broj
            var niz = PodaciFloat.Niz;

            Array.Sort(niz);

            Console.WriteLine("Najveći broj u nizu je {0}", niz[niz.Length - 1]);
        }

        private static void Zadatak13()
        {
            // Ispišite najmanji broj
            var niz = PodaciFloat.Niz;

            Array.Sort(niz);

            Console.WriteLine("Najmanji broj u nizu je {0}", niz[0]);
        }

        private static void Zadatak14()
        {
            // Ispišite prosjek svih brojeva
            var niz = PodaciFloat.Niz;
            float suma = 0;

            foreach (var n in niz)
            {
                suma += n;
            }

            Console.WriteLine("Prosjek svih brojeva iznosi {0}", suma / niz.Length);
        }

        private static void Zadatak15()
        {
            // Ispišite sve brojeve koji nemaju decimalni dio.
            var niz = PodaciFloat.Niz;

            for (int i = 0; i < niz.Length; i++)
            {
                if (niz[i] % 1 > 0 && niz[i] % 1 < 1)
                {
                    continue;
                }
                else
                {
                    Console.WriteLine(niz[i]);
                }
            }
        }

        private static void Zadatak16()
        {
            // Ispišite sve brojeve koji počinju s znamenkom 7
            var niz = PodaciFloat.Niz;
            string broj;

            for (int i = 0; i < niz.Length; i++)
            {
                broj = niz[i].ToString();
                if (broj[0] == '7')
                {
                    Console.WriteLine(niz[i]);
                }
            }
        }

        private static void Zadatak17()
        {
            // Ispišite sve brojeve koji se ponavljaju više od 10 puta
            var niz = PodaciFloat.Niz;
            int count = 0, count2 = 0;

            Array.Sort(niz);

            for (int i = 0; i < niz.Length - 1; i++)
            {
                if (niz[i] == niz[i + 1])
                {
                    count++;
                }
                else
                {
                    if (count > 10)
                    {
                        Console.WriteLine(niz[i]);
                        count2++;
                        count = 0;
                    }
                    else
                    {
                        count = 0;
                    }
                }
            }
            Console.WriteLine("Ukupno ima {0} elemenata", niz.Length);
            Console.WriteLine("Od toliko {0} se ponavlja više od 10 puta.", count2);
        }
        #endregion



        #region Metode za PodaciString


        private static void Zadatak18()
        {
            // koliko je imena u nizu?
            var niz = PodaciString.Niz;

            Console.WriteLine("U nizu se nalazi {0} imena.", niz.Length);
        }

        private static void Zadatak19()
        {
            // Kojeg imena ima najviše?
            var niz = PodaciString.Niz;
            Array.Sort(niz);

            int count = 0, countIme = 1;
            string ime = niz[0];

            for (int i = 0; i < niz.Length - 1; i++)
            {
                if (niz[i] == niz[i + 1])
                {
                    count++;
                }
                else
                {
                    if (count > countIme)
                    {
                        ime = niz[i];
                        countIme = count;
                        count = 0;
                    }
                    else
                    {
                        count = 0;
                    }
                }
            }

            Console.WriteLine("Najviše se ponavlja ime {0} sa {1} ponavljanja.", ime, countIme);

        }

        private static void Zadatak20()
        {
            // Koliko se imena pojavljuje samo jednom?


            //Oduzima jako puno vremena na provjeru
            /*
            var niz = PodaciString.Niz;
            Array.Sort(niz);
            int count = 0, countIme = 1;
            string ime = string.Empty;

            
            for (int i = 1; i < niz.Length; i++)
            {
                ime = niz[i];
                for (int j = 0; j < niz.Length; j++)
                {
                    if (ime == niz[j])
                    {
                        countIme++;
                    }
                }
                if (countIme == 1)
                {
                    count++;
                }
                else
                {
                    countIme = 1;
                }
            }

            Console.WriteLine("U nizu se nalazi {0} imena koja se pojavljuju samo jednom.", count);*/

            //Pronađeno rješenje na internetu
            var niz = PodaciString.Niz;

            Dictionary<string, int> frekvencijaPojavljivanja = new Dictionary<string, int>();

            foreach (var n in niz)
            {
                if (frekvencijaPojavljivanja.ContainsKey(n))
                {
                    frekvencijaPojavljivanja[n]++;
                }
                else
                {
                    frekvencijaPojavljivanja[n] = 1;
                }
            }

            int count = frekvencijaPojavljivanja.Count(kv => kv.Value == 1);

            Console.WriteLine("U nizu se nalazi {0} imena koja se pojavljuju samo jednom.", count);


        }

        private static void Zadatak21()
        {
            // Koliko ima imena koji imaju 7 znakova?
            var niz = PodaciString.Niz;
            int count = 0;

            for (int i = 0; i < niz.Length; i++)
            {
                if (niz[i].Trim().Length == 7)
                {
                    count++;
                }
            }

            Console.WriteLine("U nizu se nalazi {0} imena koja imaju 7 znakova", count);

        }

        private static void Zadatak22()
        {
            // Ako uzmemo pravilo da sva ženska imena završavaju s slovom a, koliko ima muškaraca?
            var niz = PodaciString.Niz;
            int count = 0;
            string ime = string.Empty;

            for (int i = 0; i < niz.Length; i++)
            {
                ime = niz[i].Trim().ToLower();
                if (ime[ime.Length - 1] != 'a')
                {
                    count++;
                }
            }
            Console.WriteLine("U nizu se nalazi {0} muških imena.", count);
        }

        private static void Zadatak23()
        {
            // Koliko imena se sastoje od dva imena (npr. MARIJAN-ZLATKO, LUCIJA-ALBINA, itd.)
            var niz = PodaciString.Niz;
            int count = 0;

            foreach (var ime in niz)
            {
                if (ime.Contains('-'))
                {
                    count++;
                }
            }

            Console.WriteLine("U nizu se nalazi {0} imena koja se sastoje od 2 imena.", count);

        }
        #endregion



        #region Metode za PodaciDateTime


        private static void Zadatak24()
        {
            // Koliko je ukupno elemenata u nizu?
            var niz = PodaciDateTime.Niz();

            Console.WriteLine("U nizu se nalazi ukupno {0} elemenata.", niz.Length);

        }

        private static void Zadatak25()
        {
            // Koliko je elemenata niza u mjesecu srpnju?
            var niz = PodaciDateTime.Niz();
            int count = 0;

            foreach (var datum in niz)
            {
                if (datum.Month == 7)
                {
                    count++;
                }
            }

            Console.WriteLine("U nizu je {0} datuma u mjesecu Srpnju.", count);

        }

        private static void Zadatak26()
        {
            // Koliko elemenata niza ima zapis s 7 sekundi?
            var niz = PodaciDateTime.Niz();
            int count = 0;

            foreach (var datum in niz)
            {
                if (datum.Second == 7)
                {
                    count++;
                }
            }

            Console.WriteLine("U nizu se nalazi {0} datuma koji imaju zapis s 7 sekundi.", count);

        }

        private static void Zadatak27()
        {
            // Koja je prosječna vrijednost svih zapisa za minute?
            var niz = PodaciDateTime.Niz();
            int suma = 0;

            foreach (var datum in niz)
            {
                suma += datum.Minute;
            }

            Console.WriteLine("Prosjecna vrijednost svih zapisa za minute iznosi: " + (float)suma / niz.Length);

        }

        private static void Zadatak28()
        {
            // U kojim sve godinama postoje zapisi?
            var niz = PodaciDateTime.Niz();
            List<string> godine = [niz[0].Year.ToString()];

            foreach (var datum in niz)
            {
                if (!godine.Contains(datum.Year.ToString()))
                {
                    godine.Add(datum.Year.ToString());
                }
            }

            godine.Sort();

            Console.WriteLine("Zapisi postoje u sljedećim godinama:");
            foreach (var godina in godine)
            {
                Console.WriteLine("{0}.", godina);
            }

        }

        private static void Zadatak29()
        {
            // Koliko je zapisa koji se mogu pojaviti samo u prijestupnim godinama?
            var niz = PodaciDateTime.Niz();
            int count = 0;


            foreach (var datum in niz)
            {
                if (datum.Year % 4 == 0)
                {
                    count++;
                }
            }

            Console.WriteLine("U nizu se nalazi {0} zapisa u prijestupnim godinama.", count);
        }

        private static void Zadatak30()
        {
            // Koliko je zapisa čije je vrijeme između 4 i 5 sati u noći?
            var niz = PodaciDateTime.Niz();
            int count = 0;

            foreach(var datum in niz)
            {
                if(datum.Hour == 4)
                {
                    count++;
                }
            }

            Console.WriteLine("U nizu je {0} zapisa čije je vrijeme između 4 i 5 sati u noći", count);
        }
        #endregion

    }
}
