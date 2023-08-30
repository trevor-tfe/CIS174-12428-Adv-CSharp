using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using FirstResponsiveWebAppStewart.Models;

namespace FirstResponsiveWebAppStewart.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.YourAge = 0;
            return View();
        }

        [HttpPost]
        public IActionResult Index(WebAppStewart model)
        {
            if (model == null)
            {
                throw new ArgumentNullException("model");
            }
            if (ModelState.IsValid)
            {
                @ViewBag.YourAge = model.AgeThisYear();
            }
            else
            {
                ViewBag.YourAge = 0;
            }
            return View(model);
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