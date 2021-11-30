using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using OdeToFood.Data;
using OdeToFood.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
namespace OdeToFood.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;
		private ApplicationDbContext _context;
		public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
		{
			_logger = logger;
			_context = context;
		}
		public IActionResult Index(string searchTerm = null)
		{
			var model = _context.Restaurants
				.OrderByDescending(
					r => r.Reviews.Average(review => review.Rating)
					)
				.Where(r => searchTerm == null || r.Name.Contains(searchTerm))
				.Select(r => new RestaurantListViewModel
				{
					Id = r.Id,
					Name = r.Name,
					City = r.City,
					Country = r.Country,
					CountOfReviews = r.Reviews.Count
				});

			return View(model);
	}
	public IActionResult About()
	{
		var model = new AboutModel()
		{
			Name = "Kristjan Kivikangur",
			Location = "Tallinn"
		};
		return View(model);
	}
	public IActionResult Privacy()
	{
		return View();
	}
	[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
	public IActionResult Error()
	{
		return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
	}
	}
}