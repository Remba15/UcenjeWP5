using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.E16NasljeđivanjePolimorfizam.Zavrsni_rad
{
    internal class Zadatak
    {
        /*
            Kreirati klase prema ERA dijagramu Vaše baze podataka
            Implementirati nasljeđivanje i prepisati metodu ToString
            
            Za svaku klasu napraviti po jedan konstruktor

            Svaku klasu instancirati u ovoj klasi
        */

        public Zadatak()
        {
            var game = new Game(1, "Mass Effect", "a", "b", "cccccc", "dddd");

            var trophy = new Trophy(1, "Trophy1", "aaaaaaa", game, "Gold", "bbbbbb");

            var player = new Player(2, "Remba15", DateTime.Now, "Croatia");

            var achieve = new Achieve(player, trophy, DateTime.Now);

        }
        
    }
}
