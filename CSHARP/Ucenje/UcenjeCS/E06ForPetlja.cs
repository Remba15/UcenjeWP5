using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E06ForPetlja
    {
        public static void Izvedi()
        {

            //Ispiši 10 puta jedno ispod drugog Osijek - s onime što smo radili dosad
            Console.WriteLine("Osijek");
            Console.WriteLine("Osijek");
            Console.WriteLine("Osijek");
            Console.WriteLine("Osijek");
            Console.WriteLine("Osijek");
            Console.WriteLine("Osijek");
            Console.WriteLine("Osijek");
            Console.WriteLine("Osijek");
            Console.WriteLine("Osijek");
            Console.WriteLine("Osijek");
            Console.WriteLine();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Osijek");
            }
            Console.WriteLine();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();

            int rezultat = 0;
            for (int i = 1; i <= 100; i++)
            {
                rezultat += i;
            }
            Console.WriteLine(rezultat);
            Console.WriteLine();

            for (int i = 1; i <= 50; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine("");

            int brojOd = 12, brojDo = 2;

            for (int i = brojOd; i >= brojDo; i--)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();

            int[] niz = { 1, 2, 1, 2, 5, 2, 5, 1, 2, 45, 12, 4, 125, 12, 51 };
            //Ispisati sve parne vrijednosti niza

            for (int i = 0; i < niz.Length; i++)
            {
                if (niz[i] % 2 == 0)
                {
                    Console.WriteLine(niz[i]);
                }
            }
            Console.WriteLine("");

            int[,] tablica = {
                {1,2,30}, //DZ 6 i 9 moraju biti ispod 0 od 30
                {4,5,6},
                {7,8,9}
            };

            for (int i = 0; i < tablica.GetLength(0); i++)
            {
                for (int j = 0; j < tablica.GetLength(1); j++)
                {
                    Console.Write(tablica[i, j] + " ");
                }
                Console.WriteLine();

            }
            Console.WriteLine();

            //tablica množenja
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.Write((i + 1) * (j + 1) + " ");
                }
                Console.WriteLine();
            }

            //petlja se može preskočiti (nastaviti) i nasilno prekinuti
            int ukupno = 0;
            for (int i = 0; i < 10; i++)
            {

                if (i == 1 || i == 3)
                {
                    continue;
                }

                if (++ukupno > 5)
                {
                    break;
                }


                Console.WriteLine(i);
            }
            Console.WriteLine();

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    break;
                }
            }


            //beskonačna petlja
            for (int i = 0; i > -1; i++)
            {
                break;
            }

            int broj = 0;
            //ispravna beskonačna petlja
            for (; ; )
            {
                Console.Write("Unesi broj između 10 i 20: ");
                broj = int.Parse(Console.ReadLine());
                if (broj >= 10 && broj <= 20)
                {
                    break;
                }
                Console.WriteLine("Neispravan unos!");
            }
            Console.WriteLine("Unijeli ste " + broj);
            Console.WriteLine();


            //nizovi + petlje

            //string tip podatka je zapravo niz znakova

            string ime1 = "Ana";
            char[] ime2 = { 'A', 'n', 'a' };

            for(int i = 0; i < ime2.Length; i++)
            {
                Console.Write(ime2[i]);
            }
            Console.WriteLine();

            for (int i = 0; i<ime1.Length; i++)
            {
                Console.Write(ime1[i]);
            }


        }
    }
}
