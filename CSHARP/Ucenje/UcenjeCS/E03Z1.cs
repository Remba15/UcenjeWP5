﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E03Z1
    {

        public static void Izvedi()
        {
            //Program od korisnika traži unos broj godina koje ima korisnik
            //Program ispisuje da li je korisnik punoljetna osoba ili ne.

            Console.WriteLine("Unesite broj godina.");
            int godine = int.Parse(Console.ReadLine());
            if (godine >= 1 && godine <= 100)
            {
                if (godine >= 18)
                {
                    Console.WriteLine("Punoljetni ste.");
                }
                else
                {
                    Console.WriteLine("Niste punoljetni.");
                }
            }
            else
            {
                Console.WriteLine("Pogrešan unos!");
            }
        }
    }
}
