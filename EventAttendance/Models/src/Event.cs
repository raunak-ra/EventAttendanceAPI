﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventAttendance.Models
{
    public class Event
    {
        public int Id { get; set; }
        public List<SubEvent> SubEvent { get; set; }
    }
}
