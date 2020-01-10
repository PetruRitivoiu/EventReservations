using EventReservations.Entities;
using System.Collections.Generic;

namespace EventReservations.Repository
{
    public interface IOrderEntityRepository
    {
        IEnumerable<OrderEntity> GetAll();

        OrderEntity Find(int id);

        OrderEntity Add(OrderEntity eventEntity);

        OrderEntity Update(OrderEntity eventEntity);

        OrderEntity Remove(OrderEntity eventEntity);
    }
}
