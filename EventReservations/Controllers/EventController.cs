using EventReservations.Models;
using EventReservations.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace EventReservations.Controllers
{
    public class EventController : Controller
    {
        private readonly IEventService _productService;
        private readonly IPurchaseStrategyService _purchaseStrategyService;
        private readonly IOrderService _orderService;

        public EventController(IEventService productService, IOrderService orderService, IPurchaseStrategyService purchaseStrategyService)
        {
            _productService = productService;
            _purchaseStrategyService = purchaseStrategyService;
            _orderService = orderService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var model = _productService.GetAll();

            return View(model);
        }

        [HttpGet]
        public IActionResult Purchase(int id)
        {
            var eventModel = _productService.GetById(id);

            return View(new PurchaseOrderModel()
            {
                EventId = eventModel.Id,
                EventAddress = eventModel.Address,
                EventName = eventModel.Name
            });
        }

        [HttpPost]
        public IActionResult Purchase(PurchaseOrderModel purchaseOrder)
        {
            var orderId = _purchaseStrategyService.ExecutePurchase(purchaseOrder);

            return RedirectToAction(nameof(EventController.PurchaseCompleted), new { orderId = orderId });
        }

        [HttpGet]
        public IActionResult PurchaseCompleted(int orderId)
        {
            var orderModel = _orderService.GetById(orderId);

            return View(orderModel);
        }
    }
}