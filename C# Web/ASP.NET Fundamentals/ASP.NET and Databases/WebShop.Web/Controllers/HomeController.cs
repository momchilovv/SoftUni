﻿using Microsoft.AspNetCore.Mvc;

namespace WebShop.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}