using OdeToFood.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OdeToFood.Data
{
    public class AppDataInit
    {
        public static void SeedRestaurant(ApplicationDbContext context)
        {
            if (!context.Restaurants.Any())
            {
                for (int i = 1; i < 1000; i++)
                {
                    _ = context.Restaurants.Add(
                       new Restaurant
                       {
                           Name = $"Cinnamon Club{i}",
                           City = "London",
                           Country = "UK",
                           Reviews = new List<RestaurantReview>
                           {
                            new RestaurantReview()
                            {
                                Rating=10,
                                Body = "Superlahe!"
                            }
                           }
                       });
                    context.Restaurants.Add(
                        new Restaurant
                        {
                            Name = $"{i} Marrakesh",
                            City = "D.C",
                            Country = "USA",
                        });
                    context.Restaurants.Add(
                        new Restaurant
                        {
                            Name = $"The House of{i} Elliot ",
                            City = "Ghent",
                            Country = "Belgium",
                        });
                }

                context.SaveChanges();
            }
        }
    }
}