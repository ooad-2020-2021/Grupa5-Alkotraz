using System;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class Pjesma
    {
        [Required]
        public string naziv { get; set; }
        [Required]
        public string zanr { get; set; }
        [Required]
        public int brojGlasova { get; set; }
        public Pjesma (string nazivPjesme,string zanrPjesme)
        {
            this.naziv = nazivPjesme;
            zanr = zanrPjesme;
        }

        public void dodajGlas()
        {
            brojGlasova++;
        }
    }
}