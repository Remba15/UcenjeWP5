using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E06Z1
    {
        internal static void Izvedi()
        {
            //Korisnik unosi dva broja
            //Program ispisuje sve brojeve između njih
            int b1 = 78;
            int b2 = 2;
            int brojOd = b1 < b2 ? b1 : b2;
            int brojDo = b1 > b2 ? b1 : b2;

            for (int i = brojOd + 1; i < brojDo; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
