using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E01Z1
    {
        internal static void Izvedi()
        {

            //zadatak
            //Korisnik unosi dva cijela broja i ispisuje njihov zbroj

            int prviBroj, drugiBroj;
            while (true)
            {
                try
                {
                    Console.WriteLine("Unesite dva cijela broja.\nPrvi broj: ");
                    prviBroj = int.Parse(Console.ReadLine());
                        
                    break;
                }
                catch
                {
                    Console.WriteLine("Pogrešan unos!");

                }
            }

            while (true)
            {
                try
                {
                    Console.WriteLine("Drugi broj: ");
                    drugiBroj = int.Parse(Console.ReadLine());

                    break;
                }
                catch
                {
                    Console.WriteLine("Pogrešan unos!");

                }
            }
            Console.WriteLine("Njihov zbroj iznosi: {0}", prviBroj + drugiBroj);
            //DZ! Dodaj beskonanu petlju za pogresne unose

        }
    }
}
