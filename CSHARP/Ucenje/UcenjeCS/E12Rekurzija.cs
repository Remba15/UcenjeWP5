using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E12Rekurzija
    {

        //Rekurzija je pojam kada metoda poziva samu sebe, pod uvjetom da ima način prekida rekurzije
        internal static void Izvedi()
        {

            //Metoda(); dovodi do stack overflowa
            Console.WriteLine(Zbroji(100));

        }

        private static void Metoda()
        {
            Metoda();
        }

        private static int Zbroji(int broj)
        {
            if (broj == 1)
            {
                return 1;
            }
            else
            {
                return broj + Zbroji(broj-1);
            }
        }
    }
}
