using EventReservations.Entities;
using EventReservations.Models;

namespace EventReservations.MapperFactory
{
    interface EventFactory
    {
        public ConcertEventModel CreateConcertEvent(EventEntity eventEntity);

        public TeatherEventModel CreateTeatherEvent(EventEntity eventEntity);
    }
}
