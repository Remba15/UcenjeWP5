using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E01Z2
    {

        //zadatak
        //Korisnik će unijeti dvoznamenkasti broj
        //Ispisuje se prva znamenka
        //56 => 5
        //11 => 1
        internal static void Izvedi()
        {
            int broj;
            while (true)
            {
                try
                {
                    Console.WriteLine("Unesite dvoznamekasti broj");
                    broj = int.Parse(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.WriteLine("Pogrešan unos");
                }
            }

            Console.WriteLine(broj/10);
        }
    }
}
