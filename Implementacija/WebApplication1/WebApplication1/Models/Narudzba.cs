using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
	public class Narudzba
	{
		[NotMapped]
		public List<Artikl> artikli { get; set; }
		[Required]
		public double cijena { get; set; }
		[Required]
		public int brojNarudzbe { get; set; }
		[Required]
		public Status statusNarudzbe { get; set; }
		[Required]
		public Stol stol { get; set; }
		[Required]
		public Placanje placanje;
		public Narudzba(List<Artikl> artikl);
	}
}
