using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OdeToFood.Data;
using OdeToFood.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OdeToFood.Controllers
{
	public class ReviewsController : Controller
	{
		private readonly ApplicationDbContext _context;

		public ReviewsController(ApplicationDbContext context)
		{
			_context = context;
		}
		// GET: ReviewsController
		public ActionResult Index([Bind(Prefix = "id")] int restaurantId)
		{
			var model = _context.Restaurants
				.FirstOrDefault(r => r.Id == restaurantId);
			if (model == null)
			{
				return NotFound();
			}
			return View(model);
		}

		[HttpGet]
		public ActionResult Create(int restaurantId)
		{
			return View();
		}
		[HttpPost]
		public ActionResult Create(RestaurantReview review)
		{
			if (ModelState.IsValid)
			{
				_context.Reviews.Add(review);
				_context.SaveChanges();
				return RedirectToAction(nameof(Index), new { id = review.RestaurantId });
			}
			return View(review);
		}
		[HttpGet]
		public ActionResult Edit(int id)
		{
			var model = _context.Reviews.Find(id);
			return View(model);
		}
		[HttpPost]
		public ActionResult Edit(RestaurantReview review)
		{
			if (ModelState.IsValid)
			{
				_context.Entry(review).State = EntityState.Modified;
				_context.SaveChanges();
				return RedirectToAction(nameof(Index), new { id = review.RestaurantId });
			}
			return View(review);
		}
	}
}
