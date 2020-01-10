using EventReservations.Entities;
using EventReservations.Models;
using EventReservations.Repository;
using EventReservations.Services.PurchaseStrategy;
using System;

namespace EventReservations.Services
{
    public class PurchaseStrategyService : IPurchaseStrategyService
    {
        private PurchaseContext purchaseContext;
        private IOrderEntityRepository _orderEntityRepository;

        public PurchaseStrategyService(IOrderEntityRepository orderEntityRepository)
        {
            purchaseContext = PurchaseContext.Instance;
            _orderEntityRepository = orderEntityRepository;
        }

        public int ExecutePurchase(PurchaseOrderModel purchaseOrder)
        {
            var purchaseStatus =  purchaseContext
                .SetStrategy(purchaseOrder.PaymentMethod)
                .ExecutePurchase(purchaseOrder);

            var orderEntity = new OrderEntity
            {
                City = purchaseOrder.City,
                Email = purchaseOrder.Email,
                EventId = purchaseOrder.EventId,
                FirstName = purchaseOrder.FirstName,
                LastName = purchaseOrder.LastName,
                NumberOfTickets = purchaseOrder.NumberOfTickets,
                PaymentMethod = purchaseOrder.PaymentMethod,
                Phone = purchaseOrder.Phone,
                PostalCode = purchaseOrder.PostalCode,
                PurchaseDate = DateTime.Now,
                Street = purchaseOrder.Street,
                Message = purchaseStatus.Message,
                Success = purchaseStatus.Success
            };

            var id = _orderEntityRepository.Add(orderEntity).Id;

            return id;
        }

    }
}
