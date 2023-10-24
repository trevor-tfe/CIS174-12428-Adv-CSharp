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
        public IActionResult Olympics(string activeCategory = "all", string activeType = "all")
        {
            ViewBag.ActiveCategory = activeCategory;
            ViewBag.ActiveSport = activeType;

            ViewBag.Sports = context.Sports.ToList();
            ViewBag.Countries = context.Countries.ToList();
            ViewBag.Categories = context.Categories.ToList();
            ViewBag.Types = context.Types.ToList();

            IQueryable<Country> query = context.Countries.OrderBy(t => t.Name);
            if (activeCategory != "all")
            {
                query = query.Where(
                    t => t.Sport.Category.CategoryName.ToLower() == activeCategory.ToLower());
            } if (activeType != "all")
            {
                query = query.Where(
                    t => t.Sport.Type.TypeName.ToLower() == activeType.ToLower());
            }
            var games = query.ToList();
            return View(games);
        }

        public IActionResult ToDo(string id) 
        {
            var filters = new Filters(id);
            ViewBag.Filters = filters;
            ViewBag.Categories = context.ToDoCategories.ToList();
            ViewBag.Statuses = context.ToDoStatuses.ToList();
            ViewBag.DueFilters = Filters.DueFilterValues;

            IQueryable<ToDo> query = context.ToDos
                .Include(t => t.Category).Include(t => t.Status);
            if (filters.HasCategory)
            {
                query = query.Where(t => t.CategoryId == filters.CategoryId);
            }
            if (filters.HasStatus)
            {
                query = query.Where(t => t.StatusId == filters.StatusId);
            }
            if (filters.HasDue)
            {
                var today = DateTime.Today;
                if (filters.IsPast) { query = query.Where(t => t.DueDate < today); }
                else if (filters.IsFuture) { query = query.Where(t => t.DueDate > today); }
                else if (filters.IsToday) { query = query.Where(t => t.DueDate == today); }
            }
            var tasks = query.OrderBy(t => t.DueDate).ToList();
            return View(tasks); 
        }

        [HttpGet]
        public IActionResult ToDoAdd()
        {
            ViewBag.Categories = context.ToDoCategories.ToList();
            ViewBag.Statuses = context.ToDoStatuses.ToList();
            var task = new ToDo { StatusId = "open" };
            return View();
        }

        [HttpPost]
        public IActionResult ToDoAdd(ToDo task)
        {
            if (ModelState.IsValid)
            {
                context.ToDos.Add(task);
                context.SaveChanges();
                return RedirectToAction("ToDo");
            }
            else
            {
                ViewBag.Categories = context.ToDoCategories.ToList();
                ViewBag.Statuses = context.ToDoStatuses.ToList();
                return View(task);
            }
        }

        [HttpPost]
        public IActionResult Filter(string[] filter)
        {
            string id = string.Join('-', filter);
            return RedirectToAction("ToDo", new {ID = id});
        }

        [HttpPost]
        public IActionResult MarkComplete([FromRoute] string id, ToDo selected)
        {
            selected = context.ToDos.Find(selected.Id)!;
            if (selected != null)
            {
                selected.StatusId = "closed";
                context.SaveChanges();
            }
            return RedirectToAction("ToDo", new { ID = id });
        }

        [HttpPost]
        public IActionResult DeleteComplete(string id) 
        {
            var toDelete = context.ToDos.Where(t => t.StatusId == "closed").ToList();
            foreach(var task in toDelete)
            {
                context.ToDos.Remove(task);
            }
            context.SaveChanges();
            return RedirectToAction("ToDo", new { ID = id });
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}