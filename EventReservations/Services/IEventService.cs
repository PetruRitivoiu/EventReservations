using EventReservations.Models;
using System;
using System.Collections.Generic;

namespace EventReservations.Services
{
    public interface IEventService
    {
        IEnumerable<EventModel> GetAll();
        EventModel GetById(Guid id);
    }
}