namespace UcenjeCS.E18KonzolnaAplikacija.Model
{
    internal class Grupa : Entitet
    {
        public string? Naziv { get; set; }
        public Smjer? Smjer { get; set; }
        public string? Predavac { get; set; }
        public int? MaksimalnoPolaznika { get; set; }
        public List<Polaznik>? Polaznici { get; set; }

        public override string ToString()
        {
            return this.Naziv + " (" + this.Smjer?.Naziv + "), " + this.Polaznici?.Count + " polaznika";
        }

        public void UnosSifreNaziva()
        {
            this.Sifra = Pomocno.UcitajRasponBroja("Unesi šifru grupe", 1, int.MaxValue);
            this.Naziv = Pomocno.UcitajString("Unesi naziv grupe", 50, true);
        }


    }
}
