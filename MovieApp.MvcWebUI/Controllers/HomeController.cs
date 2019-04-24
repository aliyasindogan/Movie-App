using Microsoft.AspNetCore.Mvc;
using MovieApp.MvcWebUI.Models;
using System.Linq;

namespace MovieApp.MvcWebUI.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View(MovieRepository.Movies);
        }
        public IActionResult Details(int id)
        {
            return View(MovieRepository.Movies.FirstOrDefault(x => x.Id == id));
        }
        public IActionResult Project(int id)
        {
            return View();
        }
    }
}