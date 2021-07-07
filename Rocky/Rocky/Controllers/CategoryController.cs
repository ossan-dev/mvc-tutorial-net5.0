using Microsoft.AspNetCore.Mvc;
using Rocky.DB;
using Rocky.Models;
using Rocky.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rocky.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        public IActionResult Index()
        {
            var output = _categoryService.GetCategories();
            return View(output);
        }
    }
}
