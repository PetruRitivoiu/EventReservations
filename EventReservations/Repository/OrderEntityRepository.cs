using EventReservations.Data;
using EventReservations.Entities;
using System;
using System.Collections.Generic;

namespace EventReservations.Repository
{
    public class OrderEntityRepository : IOrderEntityRepository
    {
        private EventReservationsDbContext _context;

        public OrderEntityRepository(EventReservationsDbContext context)
        {
            _context = context;
            _context.SaveChanges();
        }


        public OrderEntity Add(OrderEntity eventEntity)
        {
            var order = _context.Orders.Add(eventEntity);
            _context.SaveChanges();

            return order.Entity;
        }

        public OrderEntity Find(int id)
        {
            return _context.Orders.Find(id);
        }

        public IEnumerable<OrderEntity> GetAll()
        {
            return _context.Orders;
        }

        public OrderEntity Remove(OrderEntity eventEntity)
        {
            var order = _context.Orders.Remove(eventEntity);
            _context.SaveChanges();

            return order.Entity;
        }

        public OrderEntity Update(OrderEntity eventEntity)
        {
            var order = _context.Orders.Update(eventEntity);
            _context.SaveChanges();

            return order.Entity;
        }
    }
}
