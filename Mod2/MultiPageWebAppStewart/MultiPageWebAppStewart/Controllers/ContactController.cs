using Microsoft.AspNetCore.Mvc;
using MultiPageWebAppStewart.Models;

namespace MultiPageWebAppStewart.Controllers
{
    public class ContactController : Controller
    {
        private ContactContext _context { get; set; }

        public ContactController(ContactContext context) => _context = context;

        [HttpGet]
        public IActionResult Add() 
        {
            ViewBag.Action = "Add";
            return View("Add", new Contact());
        }

        [HttpPost] IActionResult Add(Contact contact)
        {
            _context.Add(contact);
            _context.SaveChanges();
            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var contact = _context.Contacts.Find(id);
            return View(contact);
        }

        [HttpPost]
        public IActionResult Delete(Contact contact)
        {
            _context.Contacts.Remove(contact);
            _context.SaveChanges();
            return RedirectToAction("Index", "Home");
        }
    }
}
