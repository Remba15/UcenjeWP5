using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.E16NasljeđivanjePolimorfizam.Zavrsni_rad
{
    internal class Player : Identity
    {

        public string? Username { get; set; }
        public DateTime? RegistrationDate { get; set; }
        public string? Region { get; set; }

        public Player() { }

        public Player(int identity, string? username, DateTime? registrationDate, string? region)
        {
            base.ID = identity;
            this.Username = username;
            this.RegistrationDate = registrationDate;
            this.Region = region;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(Username);
            sb.AppendLine(Region);
            sb.AppendLine(RegistrationDate.ToString());

            return sb.ToString();
        }
    }
}
