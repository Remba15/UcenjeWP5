using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E03Z3
    {
        public static void Izvedi()
        {
            //Program od korisnika traži unos dva cijela broja.
            //Program ispisuje manji

            Console.WriteLine("Unesite prvi broj: ");
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine("Unesite drugi broj: ");
            int y = int.Parse(Console.ReadLine());

            /*if (x > y)
            {
                Console.WriteLine("Manji broj je {0}", y);
            }
            else if (y > x)
            {
                Console.WriteLine("Manji broj je {0}", x);
            }
            else
            {
                Console.WriteLine("Brojevi su jednaki.");
            }*/


            // Isti zadatak ali za tri unesena broja ispisati najmanji.

            Console.WriteLine("Unesite treći broj: ");
            int z = int.Parse(Console.ReadLine());

            if (x < y && x < z)
            {
                Console.WriteLine("Najmanji broj je {0}", x);
            }
            else if (y < z && y < x)
            {
                Console.WriteLine("Najmanji broj je {0}", y);
            }
            else
            {
                Console.WriteLine("Najmanji broj je {0}", z);
            }
        }
    }
}
