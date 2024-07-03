using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E06Z1CiklicnaTablica
    {
        public static void Izvedi()
        {
            Console.WriteLine("Unesite broj redaka tablice: ");
            int brojRedaka = int.Parse(Console.ReadLine());

            Console.WriteLine("Unesite broj stupaca tablice: ");
            int brojStupaca = int.Parse(Console.ReadLine());



            int[,] tablica = new int[brojRedaka, brojStupaca];

            int umnozak = brojRedaka * brojStupaca;

            int korak = 1;
            int padajuciRedak = brojRedaka - 1,
                rastuciRedak = 0,
                padajuciStupac = brojStupaca - 1,
                rastuciStupac = 0;


            while(korak < umnozak)
            {
                for (int i = padajuciRedak; ;)
                {
                    for (int j = padajuciStupac; j >= rastuciStupac; j--)
                    {
                        tablica[i, j] = korak++;
                    }
                    --padajuciRedak;
                    break;
                }

                for (int j = rastuciStupac; ;)
                {
                    for (int i = padajuciRedak; i >= rastuciRedak; i--)
                    {
                        tablica[i, j] = korak++;
                    }
                    ++rastuciStupac;
                    break;
                }

                for (int i = rastuciRedak; ;)
                {
                    for (int j = rastuciStupac; j <= padajuciStupac; j++)
                    {
                        tablica[i, j] = korak++;
                    }
                    ++rastuciRedak;
                    break;
                }

                for (int j = padajuciStupac; ;)
                {
                    for (int i = padajuciRedak; i <= rastuciRedak; i++)
                    {
                        tablica[i, j] = korak++;
                    }
                    --padajuciStupac;
                    break;
                }
            }



            for (int i = 0; i < tablica.GetLength(0); i++)
            {
                for (int j = 0; j < tablica.GetLength(1); j++)
                {
                    Console.Write(String.Format("{0, 10}", tablica[i, j] + " "));
                }
                Console.WriteLine();
            }
        }
    }
}
