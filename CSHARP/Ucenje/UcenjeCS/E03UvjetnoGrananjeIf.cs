using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E03UvjetnoGrananjeIf
    {



        public static void Izvedi()
        {

            int i = 7;

            bool uvjet = i == 8;

            /*Console.WriteLine(uvjet);

            if (uvjet)
            {
                Console.WriteLine("Vrijednost varijable i je 8.");
            }

            if (i > 10)
            {
                Console.WriteLine("i je veći od 10");
            }
            else
            {
                Console.WriteLine("i nije veći od 10");
            }

            if (i > 10) Console.WriteLine("i je veći od 10.");
            else Console.WriteLine("i nije veći od 10.");*/


            int b = 2;
            /*if (b == 1)
            {
                Console.WriteLine("Nemože");
            }
            else if (b > 5)
            {
                Console.WriteLine("Ok");
            }
            else
            {
                Console.WriteLine("Ostalo");
            }*/

            int x = 2, y = 1;

            /*if (x == 1 && y == 1)
            {
                Console.WriteLine("x i y su 1");
            }

            if (x > 1 || y == 0)
            {
                Console.WriteLine("Ako je prvi zadovoljen ulazi se u if");
            }

            if (x == 3)
            {
                if (i > 0)
                {
                    int k = 9;
                    Console.WriteLine("Zadovoljeno");
                }
            }*/

            x = 0;
            if (x == 0)
            {
                Console.WriteLine("OK");
            }
            else
            {
                Console.WriteLine("NE");
            }

            //preduvjet je da if i else provode istu akciju - u ovom slučaju cw
            Console.WriteLine(x==0 ? "OK" : "NE");

        }


    }
}
