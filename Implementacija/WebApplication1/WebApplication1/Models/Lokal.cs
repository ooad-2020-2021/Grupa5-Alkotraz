using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{
    public class Lokal
    {
        [Required]
        [Key]
        public int idLokal { get; set; }
        [Required]
        public string lokacija { get; set; }
        [Required]
        public string naziv { get; set; }
        [NotMapped]
        public List<Event> eventi { get; set; }
        [NotMapped]
        public List<Pjesma> pjesme { get; set; }
        [NotMapped]
        public List<Stol> stolovi { get; set; }
        [NotMapped] 
        public List<Uposlenik> uposlenici { get; set; }
        [Required]
        public Meni ponuda { get; set; }

        public Lokal (int id, string lok, string ime, Meni meni)
        {
            idLokal = id;
            lokacija = lok;
            this.naziv = ime;
            ponuda = meni;

        }

    }
}