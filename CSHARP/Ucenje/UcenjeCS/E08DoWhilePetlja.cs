using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E08DoWhilePetlja
    {
        public static void Izvedi()
        {

            do{

                Console.WriteLine("Edunova");

            } while (false);

            while(false) Console.WriteLine("Osijek");


            int i = 0;
            do
            {
                Console.WriteLine(i++);
            } while (i < 10);



        }
    }
}
