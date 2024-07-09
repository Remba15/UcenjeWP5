using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E05Z1
    {
        internal static void Izvedi()
        {

            string ime = "ananabraparbanana";
            bool palindrom = true;

            for (int i = 0; i < ime.Length / 2; i++)
            {
                if (ime[i] != ime[ime.Length - 1  - i])
                {
                    palindrom = false;
                    break;
                }
            }

            Console.WriteLine("Riječ {0} palindrom", palindrom ? "je" : "nije");
        }
    }
}
