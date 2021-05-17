using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{
    public class Menadzer
    {
        [Required]
        public string email { get; set; }
        [Required]
        public string password { get; set; }
        [NotMapped]
        public List<Lokal> lokali { get; set; }

        public Menadzer (string mail, string pass, List<Lokal> l)
        {
            this.email = mail;
            this.password = pass;
            lokali = l;
        }

    }
}