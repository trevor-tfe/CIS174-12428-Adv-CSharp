using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using CIS174TrevorStewart.Models;

namespace CIS174TrevorStewart.Controllers
{
    public class StudentController : Controller
    {
        private StudentContext context { get; set; }

        public StudentController(StudentContext ctx) => context = ctx;
    }
}
