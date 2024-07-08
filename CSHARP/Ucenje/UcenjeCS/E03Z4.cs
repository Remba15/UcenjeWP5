using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E03Z4
    {
        internal static void Izvedi()
        {

            /*
             *  KORISTEĆI IF
             * 
                Program učitava od korisnika ime grada.U ovisnosti o imenu grada ispisuje regiju prema sljedećim pravilima:

                   Osijek -> Slavonija
                   Zadar -> Dalmacija
                   Čakovec -> Međimurje
                   Pula -> Istra
                   Za ostale unose program ispisuje: Ne znam koja je to regija.
                    */

            // dodatno: Odraditi istu logiku s switch


            Console.Write("Unesite ime grada: ");
            string grad = Console.ReadLine();

            #region IF Rješenje
            /*if (grad.ToLower().Trim() == "osijek")
            {
                Console.WriteLine("Slavonija");
            }
            else if (grad.ToLower().Trim() == "zadar")
            {
                Console.WriteLine("Dalmacija");
            }
            else if (grad.ToLower().Trim() == "cakovec")
            {
                Console.WriteLine("Međimurje");
            }
            else if(grad.ToLower().Trim() == "pula")
            {
                Console.WriteLine("Istra");
            }
            else
            {
                Console.WriteLine("Ne znam koja je to regija.");
            }*/
            #endregion

            #region SWITCH Rješenje

            switch (grad.ToLower().Trim())
            {
                case "osijek":
                    Console.WriteLine("Slavonija");
                    break;
                case "zadar":
                    Console.WriteLine("Dalmacija");
                    break;
                case "cakovec":
                    Console.WriteLine("Međimurje");
                    break;
                case "pula":
                    Console.WriteLine("Istra");
                    break;
                default:
                    Console.WriteLine("Ne znam koja je to regija.");
                    break;
            }

            #endregion

        }
    }
}
