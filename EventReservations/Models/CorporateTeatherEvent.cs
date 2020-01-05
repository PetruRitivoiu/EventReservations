using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventReservations.Models
{
    public class CorporateTeatherEvent : TeatherEvent
    {
        public CorporateTeatherEvent(int maxAttendees) : base(maxAttendees)
        {
            
        }

        public string type => "Corporate teather event";
    }
}
