using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E05Nizovi
    {
        public static void Izvedi()
        {

            int[] temperature = new int[12];

            temperature[0] = -2; //Siječanj
            temperature[1] = 0; //Veljača
            //...
            temperature[11] = -3; //Prosinac

            //Dužina niza
            Console.WriteLine(temperature.Length);

            //zadnji se u pravilu ovako postavlja
            temperature[temperature.Length - 1] = 0;

            Console.WriteLine(temperature[1]); //0

            Console.WriteLine(temperature);

            //Ispisati sve elemente niza
            Console.WriteLine(string.Join(",", temperature));

            //skraćeniji način
            int[] niz = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //Ispisati 5
            Console.WriteLine(niz[4]);

            string[] gradovi = { "Osijek", "Donji Miholjac", "Valpovo" };

            //Ispisati zadnji grad
            Console.WriteLine(gradovi[gradovi.Length - 1]);

            int[,] tablica =
            {
                {1,2,3},
                {4,5,6},
                {7,8,9}
            };
            // ispiši 6
            Console.WriteLine(tablica[1, 2]);
            // ispiši 9
            Console.WriteLine(tablica[2, 2]);

            //trodimenzionalni niz
            int[,,] kocka = { };

            
        }
    }
}
