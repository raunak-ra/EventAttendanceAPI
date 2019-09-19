using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventAttendance.Models.DB
{
    public class AttendeeDB
    {
        public static List<Attendee> attendees = new List<Attendee>(){
            new Attendee() { Id = 1, Name  = "Ram" , IsPresent = false },
            new Attendee() { Id = 2, Name  = "Apple" , IsPresent = false },
            new Attendee() { Id = 3, Name  = "Mango" , IsPresent = false },
            new Attendee() { Id = 4, Name  = "Guava" , IsPresent = false },
            new Attendee() { Id = 5, Name  = "Litchi" , IsPresent = false }
            };
    }
}
