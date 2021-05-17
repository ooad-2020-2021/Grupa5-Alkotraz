using System.ComponentModel.DataAnnotations;
using System;

namespace WebApplication1.Models
{
    public class PlacanjeUzivo : Placanje
    {
        [Required]
        public bool izvrsenoPlacanje { get; set; }

    }

}