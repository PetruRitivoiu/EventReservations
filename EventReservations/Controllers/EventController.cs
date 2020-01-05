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

            MapperFactory.EventFactory factory;

            EventModel ev;
            
            // luam din baza de date de ex evenimentul. Numele sau e "type: theater", in functie de asta

            switch ("corporate") { 
                case "corporate":
                    factory = new MapperFactory.CorporateEventFactory();
                    break;
                case "personal":
                    factory = new MapperFactory.PersonalEventFactory();
                    break;
            }

            switch ("teather")
            {
                case "teather":
                    ev = factory.createTeatherEvent();
                    break;
                case "concert":
                    ev = factory.createConcertEvent();
                    break;
            }

            // si ev reprezinta evenimentul

            // EventModel corporateTeather = 

            return View(model);
        }

        [HttpGet]
        public IActionResult Purchase(int id)
        {
            return View();
        }
    }
}