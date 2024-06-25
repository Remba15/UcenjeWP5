using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E01UlazIzlaz
    {
        public static void Izvedi()
        {

            Console.WriteLine("Pozdrav!");

            Console.Write("Upiši svoje ime: ");

            string ime = Console.ReadLine();

            Console.WriteLine("Pozdrav, " + ime +"!");

            //Formatirani način ispisa
            Console.WriteLine("Unijeli ste {0}", ime);

            //Zadatak 1: Unijeti adresu i grad te ispisati jedno ispod drugo adresu i grad

            Console.WriteLine("Unesite grad: ");
            string grad = Console.ReadLine();
            Console.WriteLine("Unesite adresu: ");
            string adresa = Console.ReadLine();

            Console.WriteLine("Grad koji ste unijeli: {0}\nAdresa koju ste unijeli: {1}", grad, adresa);
        }
    }
}
