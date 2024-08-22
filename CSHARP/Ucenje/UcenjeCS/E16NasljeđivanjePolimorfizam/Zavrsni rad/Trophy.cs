using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.E16NasljeđivanjePolimorfizam.Zavrsni_rad
{
    internal class Trophy : Identity
    {

        public string? Title { get; set; }
        public string? Description { get; set; }
        public Game? Game { get; set; }
        public string? Type { get; set; }
        public string? IconPath { get; set; }

        public Trophy() { }

        public Trophy(int identity, string? title, string? description, Game? game, string? type, string? iconPath)
        {
            base.ID = identity;
            this.Title = title;
            this.Description = description;
            this.Game = game;
            this.Type = type;
            this.IconPath = iconPath;
        }

        public override string ToString()
        {

            StringBuilder sb = new StringBuilder();

            sb.AppendLine(Title);
            sb.AppendLine(Type);
            sb.AppendLine(Description);

            return sb.ToString();
        }
    }
}
