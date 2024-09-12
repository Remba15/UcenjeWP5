using System.ComponentModel.DataAnnotations;

namespace EdunovaApp.Models
{
    public abstract class Entitet
    {
        [Key] //Dio entity framework ORM-a
        public int? Sifra { get; set; }
    }
}
