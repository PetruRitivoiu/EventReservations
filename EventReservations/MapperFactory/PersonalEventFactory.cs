using EventReservations.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventReservations.MapperFactory
{
    public class PersonalEventFactory : EventFactory
    {
        TeatherEvent EventFactory.createConcertEvent()
        {
            return new CorporateTeatherEvent();
        }

        ConcertEvent EventFactory.createTeatherEvent()
        {
            return new PersonalConcertEvent();
        }
    }
}
