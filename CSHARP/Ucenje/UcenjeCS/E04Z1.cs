using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E04Z1
    {
        public static void Izvedi()
        {
            //Korisnik unosi brojčanu vrijednost ocjene od 1 do 5
            //Program ispisuje slovno ocjenu, a ako korisnik nije unosio ocjenu
            //program ispisuje broj nije ocjena

            Console.WriteLine("Unesite ocjenu");
            int ocjena = int.Parse(Console.ReadLine());

            switch (ocjena)
            {
                case 1:
                    Console.WriteLine("Nedovoljan.");
                    break;
                case 2:
                    Console.WriteLine("Dovoljan.");
                    break;
                case 3:
                    Console.WriteLine("Dobar");
                    break;
                case 4:
                    Console.WriteLine("Vrlo dobar");
                    break;
                case 5:
                    Console.WriteLine("Odličan.");
                    break;
                default:
                    Console.WriteLine("Uneseni broj nije ocjena.");
                    break;
            }
        }
    }
}
