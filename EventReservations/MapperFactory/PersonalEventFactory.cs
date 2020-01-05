using EventReservations.Entities;
using EventReservations.Models;

namespace EventReservations.MapperFactory
{
    public class PersonalEventFactory : EventFactory
    {
        public ConcertEvent CreateConcertEvent(EventEntity eventEntity) => new PersonalConcertEvent
        {
            Address = eventEntity.Address,
            Currency = eventEntity.Currency,
            EventType = eventEntity.EventType,
            Id = eventEntity.Id,
            MaxAttendees = eventEntity.MaxAttendees,
            Name = eventEntity.Name,
            Price = eventEntity.Price
        };

        public TeatherEvent CreateTeatherEvent(EventEntity eventEntity) => new PersonalTeatherEvent
        {
            Address = eventEntity.Address,
            Currency = eventEntity.Currency,
            EventType = eventEntity.EventType,
            Id = eventEntity.Id,
            MaxAttendees = eventEntity.MaxAttendees,
            Name = eventEntity.Name,
            Price = eventEntity.Price
        };
    }
}
