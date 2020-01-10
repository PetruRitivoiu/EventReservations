using EventReservations.Entities;
using EventReservations.Models;
using EventReservations.Repository;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EventReservations.Services
{
    public class OrderService : IOrderService
    {
        private IOrderEntityRepository _orderEntityRepository;

        public OrderService(IOrderEntityRepository orderEntityRepository)
        {
            _orderEntityRepository = orderEntityRepository;
        }

        public IEnumerable<OrderModel> GetAll()
        {
            return _orderEntityRepository.GetAll().Select(x => MapToModel(x));
        }

        public OrderModel GetById(int id)
        {
            return MapToModel(_orderEntityRepository.Find(id));
        }

        private OrderModel MapToModel(OrderEntity orderEntity)
        {
            return new OrderModel
            {
                City = orderEntity.City,
                Email = orderEntity.Email,
                FirstName = orderEntity.FirstName,
                LastName = orderEntity.LastName,
                Message = orderEntity.Message,
                NumberOfTickets = orderEntity.NumberOfTickets,
                PaymentMethod = orderEntity.PaymentMethod,
                Phone = orderEntity.Phone,
                PostalCode = orderEntity.PostalCode,
                PurchaseDate = orderEntity.PurchaseDate,
                Street = orderEntity.Street,
                Success = orderEntity.Success
            };
        }
    }
}
