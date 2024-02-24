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

        //three views
        public IActionResult Index ()
        {
            return View();
        }

        public IActionResult JoelPage ()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Form()
        {
            ViewBag.Categories = _context.Categories
                .ToList();

            return View("Form", new Application());
        }

        // post to database and save it
        [HttpPost]
        public IActionResult Form (Application response)
        {
            if (ModelState.IsValid)
            {
                _context.Movies.Add(response);
                _context.SaveChanges();

                return View("Confirmation", response);
            }
            else //Invalid data
            {
                ViewBag.Categories = _context.Categories
                .ToList();

                return View(response);
            }
        }

        public IActionResult MovieCollection()
        {
            // Linq
            var movies = _context.Movies
                .Include(x => x.Category)
                .ToList();

            return View(movies);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var recordToEdit = _context.Movies
                .Single(x => x.MovieID == id);

            ViewBag.Categories = _context.Categories
                .ToList();

            return View("Form", recordToEdit);
        }

        [HttpPost]
        public IActionResult Edit(Application updatedInfo)
        {
            _context.Update(updatedInfo);
            _context.SaveChanges();

            return RedirectToAction("MovieCollection");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var recordToDelete = _context.Movies
                .Single(x => x.MovieID == id);

            return View(recordToDelete);
        }

        [HttpPost]
        public IActionResult Delete(Application movie)
        {
            _context.Remove(movie);
            _context.SaveChanges();

            return RedirectToAction("MovieCollection");
        }
    }
}
