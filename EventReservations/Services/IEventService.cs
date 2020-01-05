using EventReservations.Entities;
using System;
using System.Collections.Generic;

namespace EventReservations.Services
{
    public interface IEventService
    {
        IEnumerable<EventEntity> GetAll();
        EventEntity GetById(int id);
    }
}