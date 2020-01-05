using System;
using System.Collections.Generic;
using System.Linq;
using EventReservations.Data;
using EventReservations.Entities;

namespace EventReservations.Services
{
    public class EventService : IEventService
    {
        private readonly EventReservationsDbContext _context;

        public EventService(EventReservationsDbContext context)
        {
            _context = context;
        }

        public IEnumerable<EventEntity> GetAll()
        {
            return _context.Events.ToList();
        }

        public EventEntity GetById(int id)
        {
            return _context.Events.Find(id);
        }
    }
}
