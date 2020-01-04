using EventReservations.Models;
using EventReservations.Services;
using Microsoft.AspNetCore.Mvc;
using System;

namespace EventReservations.Controllers
{
    public class EventController : Controller
    {
        private readonly IEventService _productService;

        public EventController(IEventService productService)
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
    }
}