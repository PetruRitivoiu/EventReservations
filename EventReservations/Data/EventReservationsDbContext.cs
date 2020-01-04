using EventReservations.Entities;
using Microsoft.EntityFrameworkCore;

namespace EventReservations.Data
{
    public class EventReservationsDbContext : DbContext
    {
        public DbSet<EventEntity> Events { get; set; }

        public EventReservationsDbContext(DbContextOptions<EventReservationsDbContext> options) 
            : base(options) { }
    }
}
