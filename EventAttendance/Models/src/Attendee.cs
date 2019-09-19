using System;
using System.Collections.Generic;

namespace EventAttendance.Models
{
    public class Attendee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsPresent { get; set; }
    }
}