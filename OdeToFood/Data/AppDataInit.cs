using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OdeToFood.Models;

namespace OdeToFood.Data
{
	public class AppDataInit
	{
		public static void SeedRestaurant(ApplicationDbContext context)
		{
			if (!context.Restaurants.Any())
			{
				context.Restaurants.Add(
					new Restaurant
					{
						Name = "Cinnamon Club",
						City = "London",
						Country = "UK",
						Reviews = new List<RestaurantReview>()
						{
							new RestaurantReview()
							{
								Rating = 10,
								Body = "Superlahe"
							}
						}
					});
				context.Restaurants.Add(
					new Restaurant
					{
						Name = "Marrakesh",
						City = "D.C.",
						Country = "USA",
					});
				context.Restaurants.Add(
					new Restaurant
					{
						Name = "The House of Elliot",
						City = "Ghent",
						Country = "Belgium",
					});
				context.SaveChanges();
			}
		}
	}
}
