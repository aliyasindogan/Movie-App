using Microsoft.AspNetCore.Mvc;
using MovieApp.MvcWebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApp.MvcWebUI.ViewComponents
{
    public class MenuViewComponent:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View(CategoryRepository.Categories);
        }
    }
}
