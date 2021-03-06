﻿using EventReservations.Entities;
using EventReservations.Enums;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventReservations.Data
{

    public class DbInitializer : IDbInitializer
    {
        private readonly EventReservationsDbContext _context;

        public DbInitializer(EventReservationsDbContext context)
        {
            this._context = context;
        }

        public async Task Initialize()
        {
            _context.Database.EnsureCreated();

            if (_context.Events.Any())
            {
                return;   // DB has been seeded
            }

            var events = new List<EventEntity>
            {
                new EventEntity { Address = "Romanian Atheneum", EventType = EventType.Concert, Name = "Rachmaninoff piano concerto 2", Price=50, Currency = Currency.RON, AttendenceType = AttendenceType.Personal, MaxAttendees = 400 },
                new EventEntity { Address = "TNB", EventType = EventType.Theater, Name = "20 Years in Siberia", Price=60, Currency=Currency.RON, AttendenceType = AttendenceType.Personal, MaxAttendees = 350 },
                new EventEntity { Address = "The Roman Arenas", EventType = EventType.Concert, Name="Slayer", Price=200, Currency = Currency.RON, AttendenceType = AttendenceType.Personal, MaxAttendees = 10000 },
                new EventEntity { Address = "Quantic Club", EventType = EventType.Concert, Name = "Luna Amara", Price = 40, Currency = Currency.RON, AttendenceType = AttendenceType.Personal, MaxAttendees = 1500 },
                new EventEntity { Address = "Bulandra", EventType = EventType.Theater, Name = "Richard III", Price = 40, Currency = Currency.RON, AttendenceType = AttendenceType.Personal, MaxAttendees = 250 },
                new EventEntity { Address = "The Roman Arenas", EventType = EventType.Concert, Name = "Byron", Price = 40, Currency = Currency.RON, AttendenceType = AttendenceType.Personal, MaxAttendees = 10000 },
                new EventEntity { Address = "Fratelli", EventType = EventType.Concert, Name = "Dell Christmas Party", Price = 0, Currency = Currency.RON, AttendenceType = AttendenceType.Corporate, MaxAttendees = 600 }
            };

            _context.Events.AddRange(events);

            await _context.SaveChangesAsync();
        }
    }
}