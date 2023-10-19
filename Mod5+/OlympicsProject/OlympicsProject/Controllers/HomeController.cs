using CIS174TrevorStewart.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace CIS174TrevorStewart.Controllers
{
    public class HomeController : Controller
    {
        private OlympicsContext context {  get; set; }

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, OlympicsContext context)
        {
            _logger = logger;
            this.context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Olympics(string activeCategory = "all", string activeSport = "all")
        {
            ViewBag.ActiveCategory = activeCategory;
            ViewBag.ActiveSport = activeSport;

            ViewBag.Sports = context.Sports.ToList();
            ViewBag.Countries = context.Countries.ToList();

            IQueryable<Country> query = context.Countries.OrderBy(t => t.Name);
            if (activeCategory != "all")
            {
                query = query.Where(
                    t => t.Sport.Category.ToLower() == activeCategory.ToLower());
            } if (activeSport != "all")
            {
                query = query.Where(
                    t => t.Sport.SportName.ToLower() == activeSport.ToLower());
            }
            var games = query.ToList();
            return View(games);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}