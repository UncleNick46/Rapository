using System;
using Microsoft.AspNetCore.Mvc;
using GameShop.Core.DataModels;
using GameShop.Core.Interfaces;
using GameShop.Models;


namespace GameShop.Web.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryController(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var categories = _categoryRepository.GetAll();
            return View(categories);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(ICategory category)
        {
            if (!ModelState.IsValid)
            {
                return View(category);
            }

            _categoryRepository.Insert(category);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Update()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Update(ICategory category)
        {
            if (!ModelState.IsValid)
            {
                return View(category);
            }

            _categoryRepository.Update(category);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Delete(Guid id)
        {
            _categoryRepository.Delete(id);
            return View();
        }

        [HttpPost]
        public IActionResult Create(Category category)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            return View();
        }
    }
}
