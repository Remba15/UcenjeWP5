using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.E16NasljeđivanjePolimorfizam.Zavrsni_rad
{
    internal class Achieve
    {
        public Player? Player { get; set; }
        public Trophy? Trophy { get; set; }
        public DateTime DateAchieved { get; set; }

        public Achieve() { }

        public Achieve(Player? player, Trophy? trophy, DateTime dateAchieved)
        {
            this.Player = player;
            this.Trophy = trophy;
            this.DateAchieved = dateAchieved;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("Player ");
            sb.Append(Player);
            sb.Append(" achieved ");
            sb.Append(Trophy);
            sb.Append(" trophy at ");
            sb.Append(DateAchieved);

            return sb.ToString();
        }
    }
}
