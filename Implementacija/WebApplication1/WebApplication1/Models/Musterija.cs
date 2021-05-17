using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{
    internal class Musterija
    {
        [Required]
        public string email { get; set; }
        [Required]
        public string password { get; set;}
        [NotMapped]
        public List<Rezervacija> rezervacije { get; set; }
        public Musterija (string mail, string pass)
        {
            this.email = mail;
            this.password = pass;
        }
    }
}