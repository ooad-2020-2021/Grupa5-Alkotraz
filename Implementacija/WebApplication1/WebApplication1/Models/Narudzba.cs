using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Enums;

namespace WebApplication1.Models
{
	public class Narudzba
	{
		[Required]
		[Key]
		public int brojNarudzbe { get; set; }[NotMapped]
		public List<Artikl> artikli { get; set; }
		[Required]
		public double cijena { get; set; }
		
		[Required]
		public Status statusNarudzbe { get; set; }
		[Required]
		public Stol stol { get; set; }
		[Required]
		public Placanje placanje { get; set; }
		public Narudzba(List<Artikl> artikl)
        {
			artikli = artikl;
        }
	}
}
