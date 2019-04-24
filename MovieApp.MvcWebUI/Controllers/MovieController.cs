using Microsoft.AspNetCore.Mvc;
using MovieApp.MvcWebUI.Models;

namespace MovieApp.MvcWebUI.Controllers
{
    public class MovieController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult List()
        {
            return View(MovieRepository.Movies);
        }
    }
}