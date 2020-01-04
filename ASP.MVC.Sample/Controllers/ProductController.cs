using DellChallenge.D2.Web.Models;
using DellChallenge.D2.Web.Services;
using Microsoft.AspNetCore.Mvc;
using System;

namespace DellChallenge.D2.Web.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var model = _productService.GetAll();

            return View(model);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(ProductDetailsModel product)
        {
            if (!ModelState.IsValid)
            {
                return View(product);
            }

            _productService.Add(product);

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Update(Guid id)
        {
            ViewData["Id"] = id;

            return View(_productService.GetById(id));
        }

        [HttpPost]
        public IActionResult Update(Guid id, ProductDetailsModel product)
        {
            if (!ModelState.IsValid)
            {
                ViewData["Id"] = id;

                return View(product);
            }

            _productService.Update(id, product);

            return RedirectToAction("Index");
        }

        [HttpGet, ActionName("Delete")]
        public IActionResult ConfirmDelete(Guid id)
        {
            ViewData["Id"] = id;

            return View(_productService.GetById(id));
        }

        [HttpPost]
        public IActionResult Delete(Guid id)
        {
            _productService.Delete(id);

            return RedirectToAction("Index");
        }
    }
}