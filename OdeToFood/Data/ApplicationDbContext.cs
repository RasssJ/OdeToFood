using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using OdeToFood.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace OdeToFood.Data
{
	public class ApplicationDbContext : IdentityDbContext
	{
		public DbSet<Restaurant> Restaurants { get; set; }
		public DbSet<RestaurantReview> Reviews { get; set; }

		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
						: base(options)
		{
		}
	}
}