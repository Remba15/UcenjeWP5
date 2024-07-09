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
            try
            {
                Console.WriteLine("Unesite dva cijela broja.\nPrvi broj: ");
                int prviBroj = int.Parse(Console.ReadLine());

                Console.WriteLine("Drugi broj: ");
                int drugiBroj = int.Parse(Console.ReadLine());

                Console.WriteLine("Njihov zbroj iznosi: {0}", prviBroj + drugiBroj);
            }
            catch
            {
                Console.WriteLine("Pogrešan unos!");
            }
            //DZ! Dodaj beskonanu petlju za pogresne unose

        }
    }
}
