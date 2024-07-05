using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E07Z2
    {
        internal static void Izvedi()
        {
            //Program od korisnika unosi 10 brojeva
            //Program ispisuje prvo zbroj svih unesenih brojeva
            //i nakon toga ispisuje unesene brojeve jedno ispod drugog

            Console.WriteLine("Unesite 10 brojeva: ");
            int[] nizBrojeva = new int[10];
            int zbroj = 0;


            for (int i = 0; i < nizBrojeva.Length; i++)
            {
                Console.WriteLine("Unesite vrijednost {0}. broja: ", i + 1);
                try
                {
                    nizBrojeva[i] = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Niste unijeli broj!");
                }
                zbroj += nizBrojeva[i];
            }
            Console.WriteLine();
            Console.WriteLine(zbroj + "\n");
            foreach (var b in nizBrojeva)
            {
                Console.WriteLine(b);
            }

        }
    }
}
