﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventReservations.Models
{
    public class CorporateConcertEvent : ConcertEvent
    {
        public string type => "Corporate concert event";
    }
}
