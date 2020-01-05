using EventReservations.Entities;
using EventReservations.Models;

namespace EventReservations.MapperFactory
{
    public class CorporateEventFactory : EventFactory
    {
        public ConcertEvent CreateConcertEvent(EventEntity eventEntity) => new CorporateConcertEvent
        {
            Address = eventEntity.Address,
            Currency = eventEntity.Currency,
            EventType = eventEntity.EventType,
            Id = eventEntity.Id,
            MaxAttendees = eventEntity.MaxAttendees,
            Name = eventEntity.Name,
            Price = eventEntity.Price
        };

        public TeatherEvent CreateTeatherEvent(EventEntity eventEntity) => new CorporateTeatherEvent
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
