using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.E18KonzolnaAplikacija
{
    internal class Pomocno
    {

        public static bool DEV = false;

        public static string UcitajString(string poruka)
        {
            string s;
            while (true)
            {
                Console.Write(poruka + ": ");
                s = Console.ReadLine().Trim();
                if (s.Length == 0)
                {
                    Console.WriteLine("Obavezan unos");
                    continue;
                }
                return s;
            }

        }
    }
}
