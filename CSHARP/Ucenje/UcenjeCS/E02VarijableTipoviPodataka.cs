using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E02VarijableTipoviPodataka
    {


        public static void Izvedi()
        {
            //Deklaracija varijable
            int i;
            /*
            //Dodjeljivanje vrijednosti -> operator dodjeljivanja =
            i = 7;

            //Korištenje varijable
            Console.WriteLine(i);

            //Učitanje broja od korisnika
            Console.WriteLine("Molim upisati cijeli broj veći od nule: ");
            int broj = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(broj+1);

            //Za decimalne brojeve ćemo koristit float

            Console.WriteLine("Unesi decimalni broj (, je oznaka za decimalni broj): ");
            Console.WriteLine(float.Parse(Console.ReadLine())+1);

            //Definiranje logičke vrijednosti
            bool uvjet = false;

            Console.WriteLine(uvjet);

            //Operatori za rad s varijablama
            //=, +, -, *, /
            //== operator uspoređivanja, tipa bool
            //!= operator različito, tipa bool
            */
            int j = 3;

            Console.WriteLine(j == 3);
            Console.WriteLine(j != 3);

            //Increment i Decrement

            i = 0;
            i = i + 1;
            i += 1;
            i++;    //prvo koristi pa uvećaj
            ++i;    //prvo uvećaj pa koristi

            i = 1;
            Console.WriteLine(i++);
            Console.WriteLine(i);
            Console.WriteLine(++i);
            Console.WriteLine(i);


            //Decrement je ista stvar samo u minus
            i--;
            --i;

            //Prekrasni zadaci
            int x = 0, y = 1;
            x = ++x - y; //x = 0, y = 1
            y = x-- + y; //x = -1, y = 0 
            Console.WriteLine(x + y);

            //prvo na početku dvosatnog vježbanja doma si zadati zadatak
            //na kraju 

            // operator modulo %

            Console.WriteLine("9 % 2 = {0}", 9 % 2);
            Console.WriteLine("8 % 2 = {0}", 8 % 2);


            x = 5;
            y = 2;

            //int/int daje int, mora se raditi cast da se dobije float
            Console.WriteLine((float)x/y); //(float) cast u tip podatka float
        }
    }
}
