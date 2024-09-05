using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.E18KonzolnaAplikacija
{
    public class Izbornik
    {
        public ObradaSmjer ObradaSmjer { get; set; }
        public ObradaGrupa ObradaGrupa { get; set; }

        public Izbornik()
        {
            Pomocno.DEV = true;
            ObradaSmjer = new ObradaSmjer();
            ObradaGrupa = new ObradaGrupa(this);
            PrikaziIzbornik();
        }

        private void PrikaziIzbornik()
        {

            Console.WriteLine("Glavni izbornik:");
            Console.WriteLine("\t1. Smjerovi");
            Console.WriteLine("\t2. Grupe");
            Console.WriteLine("\t3. Polaznici");
            Console.WriteLine("\t4. Izlaz iz programa");
            OdabirOpcijeIzbornika();

        }

        private void OdabirOpcijeIzbornika()
        {
            switch(E11Metode.UcitajCijeliBroj("Odaberi stavku izbornika", 1, 4))
            {
                case 1:
                    ObradaSmjer.PrikaziIzbornik();
                    Console.Clear();
                    PrikaziIzbornik();
                    break;
                case 2:
                    ObradaGrupa.PrikaziIzbornik();
                    Console.Clear();
                    PrikaziIzbornik();
                    break;
                //NADOPUNIT ZA DZ
                case 4:
                    Console.WriteLine("Doviđenja.");
                    break;
            }

        }
    }
}
