using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EventAttendance.Models;
using EventAttendance.Models.DB;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EventAttendance.Controllers
{
    [Route("api/event/[controller]")]
    [ApiController]
    public class EventController : ControllerBase
    {
        [HttpGet]
        public List<Event> GetAllEvents()
        {
            return EventDB.events;
        }

        [HttpGet("{id}")]
        public Event GetEventById(int id)
        {
            var @event = EventDB.events.FirstOrDefault(e => e.Id == id);
            return @event;
        }

        [HttpPost]
        public object PostEvent([FromBody] Event newEvent)
        {
            EventDB.events.Add(newEvent);
            return Ok("Event added successfully.");
        }
      
        [HttpDelete]
        public object Delete(int id)
        {
            var @event = EventDB.events.FirstOrDefault(e => e.Id == id);
            EventDB.events.Remove(@event);
            return Ok("Event deleted successfully.");
        }
    }
}