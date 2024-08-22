using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.E16NasljeđivanjePolimorfizam
{
    internal class Smjer : Entitet
    {

        public string? Naziv { get; set; }


        public override string ToString()
        {
            return Sifra + ": " + Naziv;
        }
    }
}
