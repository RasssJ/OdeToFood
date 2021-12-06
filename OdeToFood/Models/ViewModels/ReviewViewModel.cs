using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OdeToFood.Models.ViewModels
{
	public class ReviewViewModel
	{
		public int Id { get; set; }
		[Range(1, 10)]
		public int Rating { get; set; }
		[Required]
		[StringLength(1024)]
		public string Body { get; set; }
	}
}
