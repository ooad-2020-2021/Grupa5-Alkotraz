using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{ 
	public class Meni
	{
		[NotMapped]
		public List<Artikl> ponuda { get; set; }
		public Meni();
		public ~Meni();
	}
}
