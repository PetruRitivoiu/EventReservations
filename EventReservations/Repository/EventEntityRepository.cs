using EventReservations.Data;
using EventReservations.Entities;
using System.Collections.Generic;

namespace EventReservations.Repository
{
    public class EventEntityRepository : IEventEntityRepository
    {
        private readonly EventReservationsDbContext _context;
        public EventEntityRepository(EventReservationsDbContext context)
        {
            _context = context;
            _context.SaveChanges();
        }

        public void Remove(EventEntity eventEntity)
        {
            _context.Events.Remove(eventEntity);
            _context.SaveChanges();
        }

        public IEnumerable<EventEntity> GetAll()
        {
            return _context.Events;
        }

        public EventEntity Find(int id)
        {
            return _context.Events.Find(id);
        }

        public void Add(EventEntity eventEntity)
        {
            _context.Events.Add(eventEntity);
            _context.SaveChanges();
        }

        public void Update(EventEntity eventEntity)
        {
            _context.Events.Update(eventEntity);
            _context.SaveChanges();
        }
    }
}
