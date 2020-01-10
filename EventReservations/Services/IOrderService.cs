using EventReservations.Models;
using System.Collections.Generic;

namespace EventReservations.Services
{
    public interface IOrderService
    {
        IEnumerable<OrderModel> GetAll();
        OrderModel GetById(int id);
    }
}
