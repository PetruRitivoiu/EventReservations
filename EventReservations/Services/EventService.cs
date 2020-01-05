using System;
using System.Collections.Generic;
using EventReservations.Data;
using EventReservations.Entities;
using EventReservations.Enums;
using EventReservations.MapperFactory;
using EventReservations.Models;

namespace EventReservations.Services
{
    public class EventService : IEventService
    {
        private readonly EventReservationsDbContext _context;

        private readonly CorporateEventFactory _corporateEventFactory;
        private readonly PersonalEventFactory _personalEventFactory;


        public EventService(EventReservationsDbContext context, CorporateEventFactory corporateEventFactory, PersonalEventFactory personalEventFactory)
        {
            _context = context;
            _corporateEventFactory = corporateEventFactory;
            _personalEventFactory = personalEventFactory;

        }

        public IEnumerable<EventModel> GetAll()
        {
            return MapEventEntityToModel(_context.Events);
        }

        public EventModel GetById(int id)
        {
            return MapEventEntityToModel(_context.Events.Find(id));
        }

        private EventModel MapEventEntityToModel(EventEntity eventEntity)
        {
            EventFactory factory = eventEntity.AttendenceType switch
            {
                AttendenceType.Corporate => _corporateEventFactory,
                AttendenceType.Personal => _personalEventFactory,
                _ => throw new NotSupportedException($"event entity attendence type has none of the values found in {nameof(AttendenceType)} enum")
            };

            EventModel ev = eventEntity.EventType switch
            {
                EventType.Theater => factory.CreateTeatherEvent(eventEntity),
                EventType.Concert => factory.CreateConcertEvent(eventEntity),
                _ => throw new NotSupportedException($"event entity event type has none of the values found in {nameof(EventType)} enum"),
            };

            return ev;
        }

        private IEnumerable<EventModel> MapEventEntityToModel(IEnumerable<EventEntity> eventEntities)
        {
            foreach (var eventEntity in eventEntities)
            {
                yield return MapEventEntityToModel(eventEntity);
            }
        }
    }
}

