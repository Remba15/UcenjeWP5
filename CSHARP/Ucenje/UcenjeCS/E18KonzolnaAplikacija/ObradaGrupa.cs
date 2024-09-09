using UcenjeCS.E18KonzolnaAplikacija.Model;

namespace UcenjeCS.E18KonzolnaAplikacija
{
    internal class ObradaGrupa
    {

        public List<Grupa>  Grupe { get; set; }
        private Izbornik Izbornik;

        public ObradaGrupa() 
        {
            Grupe = new List<Grupa>();

        }
        public ObradaGrupa(Izbornik izbornik):this()
        {
            this.Izbornik = izbornik;
        }

        public void PrikaziIzbornik()
        {
            Console.WriteLine("Izbornik za rad s grupama");
            Console.WriteLine("1. Pregled svih grupa");
            Console.WriteLine("2. Unos nove grupe");
            Console.WriteLine("3. Promjena podataka postojeće grupe");
            Console.WriteLine("4. Brisanje grupe");
            Console.WriteLine("5. Povratak na glavni izbornik");
            OdabirOpcijeIzbornika();
        }

        private void OdabirOpcijeIzbornika()
        {
           switch(Pomocno.UcitajRasponBroja("Odaberite stavku izbornika", 1, 5))
            {
                case 1:
                    PrikaziGrupe();
                    PrikaziIzbornik();
                    break;
                case 2:
                    UnosNoveGrupe();
                    PrikaziIzbornik();
                    break;
                case 3:
                    PromjeniPodatkeGrupe();
                    PrikaziIzbornik();
                    break;
                case 4:
                    ObrisiGrupu();
                    PrikaziIzbornik();
                    break;
                case 5:                    
                    Console.Clear();
                    break;
            }
        }

        private void ObrisiGrupu()
        {
            PrikaziGrupe();
            var g = Grupe[
                Pomocno.UcitajRasponBroja("Odaberi redni broj grupe za brisanje", 1, Grupe.Count) - 1
                ];
            if (Pomocno.UcitajBool("Sigurno obrisati " + g.Naziv + "? (DA/NE)", "da"))
            {
                Grupe.Remove(g);
            }
        }

        private void PromjeniPodatkeGrupe()
        {
            PrikaziGrupe();
            int index = Pomocno.UcitajRasponBroja("Odaberi redni broj grupe za promjenu (odaberi 0 za odustajanje od promjene)", 0, Grupe.Count);
            Grupa g;
            if(index == 0)
            {
                return;
            }
            else
            {
                g = Grupe[index-1];
            }

            // copy paste s linije 102 - izvući u metodu - DONE
            g.UnosSifreNaziva();
            //smjer
            Izbornik.ObradaSmjer.PrikaziSmjerove();

            g.Smjer = Izbornik.ObradaSmjer.Smjerovi[
                Pomocno.UcitajRasponBroja("Odaberi redni broj smjera", 1, Izbornik.ObradaSmjer.Smjerovi.Count) - 1];

            g.Predavac = Pomocno.UcitajString("Unesi ime i prezime predavača", 50, true);
            g.MaksimalnoPolaznika = Pomocno.UcitajRasponBroja("Unesi maksimalno polaznika", 1, 30);

            // polaznici
            g.Polaznici = UcitajPolaznike((int)g.MaksimalnoPolaznika);


        }

        private void PrikaziGrupe()
        {
            Console.WriteLine("*****************************");
            Console.WriteLine("Grupe u aplikaciji");
            int rb = 0, rbp;
            foreach(var g in Grupe)
            {
                Console.WriteLine(++rb + ". " + g.ToString());
                rbp = 0;
                g.Polaznici.Sort();
                foreach (var p in g.Polaznici) 
                {
                    Console.WriteLine("\t" + ++rbp + ". " + p.Ime + " " + p.Prezime);
                }
            }
            Console.WriteLine("****************************");
        }

        private void UnosNoveGrupe()
        {
            Console.WriteLine("***************************");
            Console.WriteLine("Unesite tražene podatke o grupi");

            Grupa g = new Grupa();
            g.UnosSifreNaziva();
            //smjer
            Izbornik.ObradaSmjer.PrikaziSmjerove();

            g.Smjer = Izbornik.ObradaSmjer.Smjerovi[
                Pomocno.UcitajRasponBroja("Odaberi redni broj smjera",1, Izbornik.ObradaSmjer.Smjerovi.Count) - 1];
            
            g.Predavac = Pomocno.UcitajString("Unesi ime i prezime predavača", 50, true);
            g.MaksimalnoPolaznika = Pomocno.UcitajRasponBroja("Unesi maksimalno polaznika", 1, 30);

            // polaznici
            g.Polaznici = UcitajPolaznike((int)g.MaksimalnoPolaznika);

            Grupe.Add(g);
        }

        private List<Polaznik> UcitajPolaznike(int maksimalnoPolaznika)
        {
            List<Polaznik> lista = new List<Polaznik>();
            while(lista.Count < maksimalnoPolaznika && Pomocno.UcitajBool("Za unos polaznika unesi DA", "da") )
            {
                Izbornik.ObradaPolaznik.PrikaziPolaznike();
                Console.WriteLine((Izbornik.ObradaPolaznik.Polaznici.Count + 1) + ". Dodaj novog polaznika");
                var odabranaOpcija = Pomocno.UcitajRasponBroja("Odaberi redni broj polaznika ili zadnji broj za dodavanje novog", 1,
                        Izbornik.ObradaPolaznik.Polaznici.Count + 1);
                if(odabranaOpcija == Izbornik.ObradaPolaznik.Polaznici.Count + 1)
                {
                    //ide novi
                }
                else
                {
                    lista.Add(Izbornik.ObradaPolaznik.Polaznici[odabranaOpcija]);
                }
                
            }

            return lista;
        }
    }
}
