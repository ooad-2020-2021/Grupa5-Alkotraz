using System;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
	public  class KarticnoPlacenje : Placanje
	{
		[Required]
		public string brojKartice { get; set; }
		[Required]
		[DataType(DataType.Date)]
		public DateTime datumIsteka { get; set; }
		[Required]
		public int CVV { get; set; }
	}
}
