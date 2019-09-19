using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventAttendance.Models.DB
{
    public class AttendeeDB
    {
      
        public static List<Attendee> attendees = SubEventDB.subEvents.SelectMany(b => b.Attendees)
                                                                     .GroupBy(test => test.Id)
                                                                     .Select(grp => grp.First())
                                                                     .ToList();       
    }
}
