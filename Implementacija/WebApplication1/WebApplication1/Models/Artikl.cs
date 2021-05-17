using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
	public class Artikl
	{
		[Required]
		public String naziv { get; set; }
		[Required]
		public double cijena { get; set; }
		[Required]
		public int kolicina { get; set; }
		public Artikl(String ime, double cijena)
        {
			naziv = ime;
			this.cijena = cijena;
        }
		
	}
}
