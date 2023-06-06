using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace MudBlazorCrudST.Data
{
	public class Animal
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int AnimalId { get; set; } = 0;
		public string Name { get; set; }
		public string Breed { get; set; }
		public DateTime BirthDate { get; set; }
		public string Sex { get; set; }
		public decimal Price { get; set; }
		public string Status { get; set; }
		public Boolean Selected { get; set; } = false;
		
	}
}
