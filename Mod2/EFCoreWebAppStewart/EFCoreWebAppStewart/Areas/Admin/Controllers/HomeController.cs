using Microsoft.AspNetCore.Mvc;

namespace EFCoreWebAppStewart.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _log;

        [Route("[area]/[controller]/{id?}")]
        public IActionResult Admin()
        {
            return View();
        }
    }
}