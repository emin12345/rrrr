using System;
using Microsoft.AspNetCore.Mvc;

namespace newNest.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

