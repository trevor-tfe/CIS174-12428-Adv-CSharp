using EFCoreWebAppStewart.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace EFCoreWebAppStewart.Controllers
{
    public class HomeController : Controller
    {
        private MovieContext context { get; set; }

        private readonly ILogger<HomeController> _logger;

        public HomeController(MovieContext ctx, ILogger<HomeController> logger) { context = ctx; _logger = logger; }


        public IActionResult Index()
        {
            var movies = context.Movies.Include(m => m.Genre).OrderBy(m => m.Name).ToList();
            return View(movies);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult User()
        {
            return View();
        }

        [Route("Home/Capybara")]
        public IActionResult Random(int num = 1)
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

