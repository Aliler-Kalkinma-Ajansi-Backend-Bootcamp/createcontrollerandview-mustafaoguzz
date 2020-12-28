using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace web.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Title"] = "Kategori Listesi";
            return View();
        }

        public IActionResult GetCategory()
        {
            return View();
        }
    }
}
