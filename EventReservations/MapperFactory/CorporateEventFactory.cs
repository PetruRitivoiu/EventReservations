using EventReservations.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventReservations.MapperFactory
{
    public class CorporateEventFactory : EventFactory
    {
        public EventModel createConcertEvent()
        {
            return new CorporateTeatherEvent();
        }

        public EventModel createTeatherEvent()
        {
            return new CorporateTeatherEvent();
        }
    }
}
