using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MultiPageWebAppStewart.Models;
using System.Diagnostics;

namespace MultiPageWebAppStewart.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private ContactContext _context {  get; set; }

        public HomeController(ContactContext ctx, ILogger<HomeController> logger) { _context = ctx; _logger = logger; }

        public IActionResult Index()
        {
            var contacts = _context.Contacts.OrderBy(c => c.Name).ToList();
            return View(contacts);
        }

        public IActionResult Privacy()
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