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

        int maxAttendees;
        int attendees = 0;

        public EventModel(int maxAttendees)
        {
            this.maxAttendees = maxAttendees;
        }

        public int Register(int nr = 1)
        {
            this.attendees += nr;
            return this.attendees;
        }

        public bool isFull => (maxAttendees - this.attendees) > 0;

        public string GetDescription()
        {
            return "Un eveniment";
        }
    }
}
