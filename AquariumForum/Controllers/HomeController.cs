using System.Diagnostics;
using AquariumForum.Models;
using Microsoft.AspNetCore.Mvc;

namespace AquariumForum.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}
