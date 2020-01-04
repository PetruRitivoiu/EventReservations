using System;
using System.Collections.Generic;
using EventReservations.Models;

namespace EventReservations.Services
{
    public class EventService : IEventService
    {
        public IEnumerable<EventModel> GetAll()
        {
            return null;
        }

        public EventModel GetById(Guid id)
        {
            // come here later and fix this shit
            return null;
        }
    }
}
