using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OdeToFood.Controllers
{
	public class CuisineController : Controller
	{
		public IActionResult Search(string name = "french")
		{
			return Content("Esimene:" + name);
		}
		[ActionName("Otsi")]

		public IActionResult Search()
		{
			return Content("Search!");
		}
	}
}
