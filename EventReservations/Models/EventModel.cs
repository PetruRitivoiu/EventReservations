using EventReservations.Enums;

namespace EventReservations.Models
{
    public class EventModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public double Price { get; set; }
        public Currency Currency { get; set; }
        public EventType EventType { get; set; }
    }
}
