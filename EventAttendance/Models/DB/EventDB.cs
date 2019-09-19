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
                SubEvent = SubEventDB.subEvents      // for demo purposes
            }


        };
         
      
    }
}
