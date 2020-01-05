using EventReservations.Enums;

namespace EventReservations.Models
{
    public abstract class EventModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public double Price { get; set; }
        public Currency Currency { get; set; }
        public EventType EventType { get; set; }

        public int MaxAttendees { get; set; }

        public int Attendees { get; set; } = 0;

        public EventModel()
        {
        }

        public int Register(int nr = 1)
        {
            Attendees += nr;
            return Attendees;
        }

        public bool IsFull => (MaxAttendees - Attendees) <= 0;

        public string GetDescription()
        {
            return "Un eveniment";
        }
    }
}
