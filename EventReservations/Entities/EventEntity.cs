using EventReservations.Enums;

namespace EventReservations.Entities
{
    public class EventEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public double Price { get; set; }
        public int MaxAttendees { get; set; }
        public Currency Currency { get; set; }
        public EventType EventType { get; set; }
        public AttendenceType AttendenceType { get; set; }
    }
}
