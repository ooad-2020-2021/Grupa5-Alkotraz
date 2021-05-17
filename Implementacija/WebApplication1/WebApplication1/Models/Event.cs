using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace WebApplication1.Models
{
    public class Event
    {  
        [Required]
        [Key]
        public int eventId { get; set; }
        [Required]
        public string naziv { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime datumEventa { get; set; }
        [Required]
        [DataType(DataType.Time)]
        public DateTime vrijemeEventa { get; set; }

        public Event (int id,  string ime, DateTime datum, DateTime vrijeme)
        {
            eventId = id;
            this.naziv = ime;
            datumEventa = datum;
            vrijemeEventa = vrijeme;
        }
    }
}