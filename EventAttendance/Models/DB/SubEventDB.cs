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
            // Sample Data.
            new SubEvent()
            { Id = 1, Details="EventA", Attendees = new List<Attendee>()
                                     {
                                        new Attendee() { Id = 1, Name  = "Ram" , IsPresent = false },
                                        new Attendee() { Id = 2, Name  = "Shyam" , IsPresent = false },
                                        new Attendee() { Id = 3, Name  = "Mohan" , IsPresent = false },
                                        new Attendee() { Id = 4, Name  = "Krishna" , IsPresent = false },
                                        new Attendee() { Id = 5, Name  = "Vishnu" , IsPresent = false },
                                      }
            },

           new SubEvent()
           { Id = 2, Details="EventB", Attendees = new List<Attendee>()
                                    {
                                      new Attendee() { Id = 11, Name  = "Grapes" , IsPresent = false },
                                      new Attendee() { Id = 12, Name  = "Apple" , IsPresent = false },
                                      new Attendee() { Id = 13, Name  = "Mango" , IsPresent = false }
                                    }
            }


        };
    }
}
