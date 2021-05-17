using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models 
{
	public class Stol {
        [Required]
		public int brojStola { get; set; }
		[Required]
        public bool daLiJeZauzet { get; set; }
		[Required]
		public int brojOsoba { get; set; }
		[NotMapped]
		public List<Narudzba> narudzbe { get; set; }
		[NotMapped]
		public List<Pjesma> pjesme { get; }

		public Stol (int broj, int brOsoba )
        {
			brojStola = broj;
			brojOsoba = brOsoba;
        }


	    
}
