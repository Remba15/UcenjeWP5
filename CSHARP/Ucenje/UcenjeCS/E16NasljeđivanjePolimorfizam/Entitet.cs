using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.E16NasljeđivanjePolimorfizam
{
    //Apstraktna klasa je ona klasa koja se ne može instancirati
    //Ona se kreira da bi ju druge klase nasljedile i nadopunile
    internal abstract class Entitet
    {

        public int? Sifra { get; set; }

        public override string ToString()
        {
            return Sifra.ToString();
        }

    }
}
