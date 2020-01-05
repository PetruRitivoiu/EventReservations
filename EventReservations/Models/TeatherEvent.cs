using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventReservations.Models
{
    public class TeatherEvent : EventModel
    {
        public TeatherEvent(int maxAttendees) : base(maxAttendees)
        {

        }
    }
}
