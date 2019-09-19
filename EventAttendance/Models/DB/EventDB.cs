using EventAttendance.Models.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventAttendance.Models
{
    public class EventDB
    {


        public static List<Event> events = new List<Event>()
        {
            
            new Event()
            {
                Id = 1,
                SubEvent = SubEventDB.subEvents      // for demo purposes
            }


        };
         
      
    }
}
