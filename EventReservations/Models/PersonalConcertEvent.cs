﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventReservations.Models
{
    public class PersonalConcertEvent : ConcertEvent
    {
        public PersonalConcertEvent(int maxAttendees) : base(maxAttendees)
        {
            
        }
    }
}