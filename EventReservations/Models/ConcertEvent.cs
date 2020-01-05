using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventReservations.Models
{
    public class ConcertEvent : EventModel
    {
        public ConcertEvent(int maxAttendees) : base(maxAttendees)
        {

        }
    }
}
