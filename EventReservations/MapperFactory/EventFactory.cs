using EventReservations.Entities;
using EventReservations.Models;

namespace EventReservations.MapperFactory
{
    interface EventFactory
    {
        public ConcertEvent CreateConcertEvent(EventEntity eventEntity);

        public TeatherEvent CreateTeatherEvent(EventEntity eventEntity);
    }
}
