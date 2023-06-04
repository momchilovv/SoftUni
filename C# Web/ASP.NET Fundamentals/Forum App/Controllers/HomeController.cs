using ForumApp.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ForumApp.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}