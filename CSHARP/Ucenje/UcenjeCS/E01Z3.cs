using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E01Z3
    {
        internal static void Izvedi()
        {
            //zadatak
            //Program od korisnika učitava ime grada i broj stanovnika.
            //Ispisuje rečenicu: U XXXXXX živi XXXXX ljudi.

            //DZ Osigurati da se upiše grad (sklonit razmake i to)
            //Osigurati da se upiše broj stanovnika kao broj

            Console.WriteLine("Unesite ime grada:");
            string grad = Console.ReadLine();

            Console.WriteLine("Unesite broj stanovnika:");
            int stanovnici = int.Parse(Console.ReadLine());

            Console.WriteLine("U {0} živi {1} ljudi.", grad, stanovnici);


        }
    }
}
