using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventReservations.MapperFactory
{
    interface EventFactory
    {
        public Models.EventModel createTeatherEvent();

        public Models.EventModel createConcertEvent();
    }
}
