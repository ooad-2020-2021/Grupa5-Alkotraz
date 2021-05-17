using System;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class Uposlenik
    { 
        
        [Required]
        [Key]
        public int idUposlenik { get; set; }
        [Required] 
        public string email { get; set; }
        [Required]
        public string password { get; set; }
        [Required]
        public Lokal radnoMjesto { get; set; }
       public Uposlenik (int id, string mail,string pass, Lokal lokal)
        {
            idUposlenik = id;
            this.email = mail;
            this.password = pass;
            radnoMjesto = lokal;
        }
    }
}