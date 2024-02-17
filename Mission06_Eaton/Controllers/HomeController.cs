using Microsoft.AspNetCore.Mvc;
using Mission06_Eaton.Models;
using System.Diagnostics;
using Microsoft.EntityFrameworkCore;

namespace Mission06_Eaton.Controllers
{
    public class HomeController : Controller
    {
        private MovieContext _context;

        public HomeController(MovieContext temp)
        {
            _context = temp;
        }

        public IActionResult Index ()
        {
            return View();
        }

        public IActionResult JoelPage ()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Form ()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Form (Application response)
        {
            _context.Movies.Add(response);
            _context.SaveChanges();

            return View("Confirmation", response);
        }
    }
}
