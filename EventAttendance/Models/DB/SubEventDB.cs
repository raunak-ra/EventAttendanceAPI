using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventAttendance.Models.DB
{
    public class SubEventDB
    {
        public static List<SubEvent> subEvents = new List<SubEvent>()
        {
            new SubEvent() { Id = 1, Details="EventA", Attendees = AttendeeDB.attendees },
            new SubEvent() { Id = 2, Details="EventB", Attendees = AttendeeDB.attendees }
        };
    }
}
