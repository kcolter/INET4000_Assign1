using System.Diagnostics;
using AquariumForum.Data;
using AquariumForum.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AquariumForum.Controllers
{
    public class HomeController : Controller
    {

        private readonly AquariumForumContext _context;

        public HomeController(AquariumForumContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var discussions = await _context.Discussion.OrderByDescending(d => d.CreateDate).ToListAsync();

            return View(discussions); //pass in our ordered discussions
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}
