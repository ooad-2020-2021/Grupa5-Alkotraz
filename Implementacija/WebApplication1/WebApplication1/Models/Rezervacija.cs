using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
	public class Rezervacija
	{
		[Required]
		public Stol izabraniStol { get; set; }
		[Required]
		[DataType(DataType.Date)]
		public DateTime datumRezervacije { get; set; }
		[Required]
		[DataType(DataType.Time)]
		public DateTime vrijemeRezervacije { get; set; }
		[Required]
		public int kodRezervacije { get; set; }
		public Rezervacija(Stol stol, DateTime datum, DateTime vrijeme)
        {
			izabraniStol = stol;
			datumRezervacije = datum;
			vrijemeRezervacije = vrijeme;
        }
	}
}
