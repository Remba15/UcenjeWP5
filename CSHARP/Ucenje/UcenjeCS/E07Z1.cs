using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E07Z1
    {
        internal static void Izvedi()
        {

            //Program od korisnika unosi cijeli broj (osigurava se unos)
            //Koristeći While petlju, program ispisuje
            //zbroj svih parnih brojeva od 1 do unesenog broja (skupa s njim)
            //Primjer:
            //  * unos 10 ispis 30
            //  * unos 12 ispis 42

            int broj,
                suma = 0;

            while (true)
            {
                Console.WriteLine("Unesite cijeli broj.");
                try
                {
                    broj = int.Parse(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.WriteLine("Niste unijeli cijeli broj!");
                }
            }
            
            while(broj > 0)
            {
                if(broj % 2 == 0)
                {
                    suma += broj;
                    broj--;
                }
                else
                {
                    broj--;
                }
            }
            Console.WriteLine("Suma iznosi: {0}", suma);

        }
    }
}
