using Microsoft.Extensions.Logging;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OdeToFood.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace OdeToFoodTest.Controllers
{
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClass]
    public class HomecontrollersTest
    {
        [TestMethod]
        public void About()
        {
            using var logFactory = LoggerFactory.Create(ControllerBuilder => ControllerBuilder.AddConsole());
            var logger = logFactory.CreateLogger<HomeController>(logger);
            HomeController controller = new HomeController();
            ViewResult result = controller.About() as ViewResult;
            Assert.IsNotNull(result.Model);
        }
    }
}
