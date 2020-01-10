using EventReservations.Entities;
using EventReservations.Models;

namespace EventReservations.MapperFactory
{
    public class CorporateEventFactory : EventFactory
    {
        public ConcertEventModel CreateConcertEvent(EventEntity eventEntity) => new CorporateConcertEventModel
        {
            Address = eventEntity.Address,
            Currency = eventEntity.Currency,
            EventType = eventEntity.EventType,
            Id = eventEntity.Id,
            MaxAttendees = eventEntity.MaxAttendees,
            Name = eventEntity.Name,
            Price = eventEntity.Price
        };

        public TeatherEventModel CreateTeatherEvent(EventEntity eventEntity) => new CorporateTeatherEventModel
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
