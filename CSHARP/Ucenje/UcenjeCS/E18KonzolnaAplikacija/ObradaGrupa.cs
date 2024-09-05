using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UcenjeCS.E18KonzolnaAplikacija.model;

namespace UcenjeCS.E18KonzolnaAplikacija
{
    public class ObradaGrupa
    {

        public List<Grupa> Grupe { get; set; }
        public Izbornik Izbornik { get; set; }

        public ObradaGrupa(Izbornik Izbornik)
        {
            this.Izbornik = Izbornik;
            Grupe = new List<Grupa>();
            if (Pomocno.DEV)
            {
                UcitajTestnePodatke();
            }
        }

        public void PrikaziIzbornik()
        {
            Console.WriteLine("Rad s grupama");
            Console.WriteLine("\t1. Prikaži sve grupe.");
            Console.WriteLine("\t2. Dodaj novu grupu");
            Console.WriteLine("\t3. Promjeni grupu");
            Console.WriteLine("\t4. Brisanje grupu");
            //NADOPUNIT ZA DZ
            Console.WriteLine("\t5. Povratak na glavni izbornik.");
            OdabirOpcijeIzbornika();
        }

        private void OdabirOpcijeIzbornika()
        {

            switch(E11Metode.UcitajCijeliBroj("Odaberi stavku izbornika", 1, 5))
            {
                case 1:
                    PrikaziSveGrupe();
                    PrikaziIzbornik();
                    break;
                case 2:
                    DodajNovuGrupu();
                    PrikaziIzbornik();
                    break;
                case 5:
                    break;

            }

        }

        private void DodajNovuGrupu()
        {

            var g = new Grupa();
            g.Sifra = E11Metode.UcitajCijeliBroj("Unesi šifru grupe", 1, int.MaxValue);
            g.Naziv = Pomocno.UcitajString("Unesi naziv grupe");
            var ios = Izbornik.ObradaSmjer;
            ios.PrikaziSveSmjerove();
            g.Smjer = ios.Smjerovi[
                    E11Metode.UcitajCijeliBroj("Odaberite smjer za ovu grupu", 1, ios.Smjerovi.Count) - 1
                ];

            Grupe.Add(g);

        }

        private void PrikaziSveGrupe()
        {
            if (Grupe.Count == 0)
            {
                var staraB = Console.BackgroundColor;
                var staraF = Console.ForegroundColor;

                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("Nema grupa u bazi.");
                Console.BackgroundColor = staraB;
                Console.ForegroundColor = staraF;
                return;
            }

            var rb = 0;

            foreach (var e in Grupe)
            {
                Console.WriteLine("\t" + ++rb + ". " + e.Naziv);
            }
        }

        private void UcitajTestnePodatke()
        {

            Grupe.Add(new() { Sifra = 1, Naziv = "WP5", Smjer = Izbornik.ObradaSmjer.Smjerovi[0] });
            Grupe.Add(new() { Sifra = 1, Naziv = "WP4", Smjer = Izbornik.ObradaSmjer.Smjerovi[0] });

        }
    }
}
