using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UcenjeCS.E18KonzolnaAplikacija.model;

namespace UcenjeCS.E18KonzolnaAplikacija
{
    public class ObradaSmjer
    {

        public List<Smjer> Smjerovi { get; set; }

        public ObradaSmjer()
        {
            Smjerovi = new List<Smjer>();
            if (Pomocno.DEV)
            {
                UcitajTestnePodatke();
            }
        }

        private void UcitajTestnePodatke()
        {
            Smjerovi.Add(new() { Sifra = 1, Naziv = "Web programiranje" });
            Smjerovi.Add(new() { Sifra = 1, Naziv = "AAAA" });
            Smjerovi.Add(new() { Sifra = 1, Naziv = "BBBB" });
            Smjerovi.Add(new() { Sifra = 1, Naziv = "CCCC" });
            Smjerovi.Add(new() { Sifra = 1, Naziv = "DDDD" });

        }

        public void PrikaziIzbornik()
        {
            Console.WriteLine("Rad s smjerovima");
            Console.WriteLine("\t1. Prikaži sve smjerove.");
            Console.WriteLine("\t2. Dodaj novi smjer");
            Console.WriteLine("\t3. Promjeni smjer");
            Console.WriteLine("\t4. Brisanje smjera");
            //NADOPUNIT ZA DZ
            Console.WriteLine("\t5. Povratak na glavni izbornik.");
            OdabirOpcijeIzbornika();
        }

        private void OdabirOpcijeIzbornika()
        {

            switch (E11Metode.UcitajCijeliBroj("Odaberi stavku izbornika", 1, 5))
            {
                case 1:
                    PrikaziSveSmjerove();
                    PrikaziIzbornik();
                    break;
                case 2:
                    DodajNoviSmjer();
                    PrikaziIzbornik();
                    break;
                case 3:
                    PromjeniSmjer();
                    PrikaziIzbornik();
                    break;
                case 4:
                    ObrisiSmjer();
                    PrikaziIzbornik();
                    break;
                //NADOPUNITI ZA DZ
                case 5:
                    break;
            }
        }

        private void ObrisiSmjer()
        {

            PrikaziSveSmjerove();
            Smjerovi.RemoveAt(
                E11Metode.UcitajCijeliBroj("Odaberi redni broj smjera za brisanje", 1, Smjerovi.Count)-1
                );

        }

        private void PromjeniSmjer()
        {
            PrikaziSveSmjerove();
            var s = Smjerovi[
                E11Metode.UcitajCijeliBroj("Odaberi redni broj smjera", 1, Smjerovi.Count) - 1
                ];

            s.Sifra = E11Metode.UcitajCijeliBroj("Unesi novu vrijednost šifru (" + s.Sifra + ")", 1, int.MaxValue);
            s.Naziv = Pomocno.UcitajString("Unesi novu vrijednost za naziv (" + s.Naziv + ")");
        }

        private void DodajNoviSmjer()
        {

            Smjerovi.Add(new()
            {
                Sifra = E11Metode.UcitajCijeliBroj("Unesi šifru smjera: ", 1, int.MaxValue),
                Naziv = Pomocno.UcitajString("Unesi naziv smjera")
            });

        }

        public void PrikaziSveSmjerove()
        {
            if (Smjerovi.Count == 0)
            {
                var staraB = Console.BackgroundColor;
                var staraF = Console.ForegroundColor;

                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("Nema smjerova u bazi.");
                Console.BackgroundColor = staraB;
                Console.ForegroundColor = staraF;
                return;
            }

            var rb = 0;

            foreach (var s in Smjerovi)
            {
                Console.WriteLine("\t" + ++rb + ". " + s.Naziv);
            }

        }
    }
}
