using Microsoft.AspNetCore.Mvc;

namespace MVCIntroDemo.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Message = "Hello World!";
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult About()
        {
            ViewBag.Message = "This is an ASP.NET Core MVC app.";
            return View();
        }

        public IActionResult Numbers()
        {
            return View();
        }

        [HttpGet]
        public IActionResult NumbersToN()
        {
            ViewBag.Count = 3;
            return View();
        }

        [HttpPost]
        public IActionResult NumbersToN(int count = 3)
        {
            int.TryParse(Request.Form["count"], out count);

            ViewBag.Count = count; 

            return View();
        }
    }
}