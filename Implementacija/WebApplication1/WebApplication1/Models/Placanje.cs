using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
	{
	    public class Placanje
    {
		[Required]
		[DataType(DataType.Date)]
		public DateTime datumUplate { get; set; }
		[Required]
		[DataType(DataType.Time)]
		public DateTime vrijemeUplate { get; set; }
		[Required]
		public double iznosUplate { get; set; }
		public Placanje(DateTime datum, DateTime vrijeme, double iznos)
        {
			datumUplate = datum;
			vrijemeUplate = vrijeme;
			iznosUplate = iznos;
        }
	}
		
	}
