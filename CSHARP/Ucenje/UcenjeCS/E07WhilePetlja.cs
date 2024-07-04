using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E07WhilePetlja
    {
        public static void Izvedi()
        {

            int brojDo = 10;

            for (int i = 0; i < brojDo; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("*****************");

            //while radi s bool tipom podatka
            //beskonacna petlja
            while (true)
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.Write(new Random().Next() + " ");
                }
                Console.WriteLine();
                Thread.Sleep(100);
                break;
            }
            Console.WriteLine("*****************");

            brojDo = 10;
            while (brojDo-- > 0)
            {
                Console.WriteLine(brojDo);
            }
            Console.WriteLine("*****************");

            int j = 2;
            while (brojDo < 10 && j == 2)
            {
                Console.WriteLine(brojDo++);
            }

            Console.WriteLine("*****************");

            brojDo = 0;
            while(brojDo < 10)
            {
                if(++brojDo == 2)
                {
                    continue;
                }
                Console.WriteLine(brojDo);
            }

            Console.WriteLine("*****************");


            brojDo = 1;
            while(brojDo < 10)
            {
                j = 1;
                while(j <= 10)
                {
                    Console.Write(brojDo * j++ + "\t");
                }
                Console.WriteLine();
                brojDo++;
            }


            brojDo = 0;
            while(brojDo > 0)
            {
                Console.WriteLine(brojDo); //ovo se neće ispisati.
            }
            
        }
    }
}
