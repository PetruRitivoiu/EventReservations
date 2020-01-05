using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventReservations.Models
{
    public class PersonalTeatherEvent : TeatherEvent
    {
        public PersonalTeatherEvent(int maxAttendees) : base(maxAttendees)
        {
            
        }

        public string type => "Personal teather event";
    }
}
