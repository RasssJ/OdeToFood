using Microsoft.AspNetCore.Mvc;
using OdeToFood.Data;
using OdeToFood.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OdeToFood.Components
{
	[ViewComponent(Name = "BestReview")]
	public class BestReview : ViewComponent
	{
		private List<RestaurantReview> _reviews;
		public BestReview()
		{
			//_reviews = Controllers.ReviewsController._reviews;
		}
		public async Task<IViewComponentResult> InvokeAsync()
		{
			var best = _reviews.OrderByDescending(r => r.Rating).First();
			return View("_bestReview", best);
		}
	}
}