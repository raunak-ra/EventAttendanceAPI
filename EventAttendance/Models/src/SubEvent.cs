using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventAttendance.Models
{
    public class SubEvent
    {
        public int Id { get; set; }
        public string Details { get; set; }

        public List<Attendee> Attendees { get; set; }
    }
}