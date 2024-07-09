using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E07Z3
    {
        internal static void Izvedi()
        {
            //Program unosi brojeve sve dok se ne unese broj -1
            //Program ispisuje zbroj svih unesenih brojeva.
            int broj, suma = 0;
            while (true)
            {
                Console.WriteLine("Unesite broj.");
                broj = int.Parse(Console.ReadLine());
                if (broj == -1)
                {
                    break;
                }
                suma += broj;
            }
            Console.WriteLine("Suma iznosi {0}", suma);

        }

    }
}
