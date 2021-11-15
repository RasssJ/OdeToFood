using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OdeToFood.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdeToFood.Tests.Controllers
{
	[TestClass]
	public class HomeControllerTests
	{
		[TestMethod]
		public void About()
		{
			using var logFactory = LoggerFactory.Create(builder => builder.AddConsole());
			var logger = logFactory.CreateLogger<HomeController>();
			HomeController controller = new HomeController(logger);
			ViewResult result = controller.About() as ViewResult;
			Assert.IsNotNull(result.Model);
		}
	}
}
