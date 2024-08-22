using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.E16NasljeđivanjePolimorfizam.Zavrsni_rad
{
    internal class Game : Identity
    {

        public string? Title { get; set; }

        public string? Developer { get; set; }

        public string? Platform { get; set; }

        public string? Description { get; set; }

        public string? CoverImagePath { get; set; }

        public Game() { }

        public Game(int identity, string? title, string? developer, string? platform, string? description, string? coverImagePath)
        {
            base.ID = identity;
            this.Title = title;
            this.Developer = developer;
            this.Platform = platform;
            this.Description = description;
            this.CoverImagePath = coverImagePath;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(this.Title);
            sb.AppendLine("Developed by: " + this.Developer);
            sb.AppendLine("Made for: " + this.Platform);
            sb.AppendLine(Description);


            return sb.ToString();
        }
    }
}
