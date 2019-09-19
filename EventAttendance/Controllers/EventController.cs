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
    [Route("api/[controller]")]
    [ApiController]
    public class EventController : ControllerBase
    {
        [HttpGet]
        public List<Event> GetAllEvents()
        {
            return EventDB.events;
        }

        [HttpPost("add")]
        public object PostEvent([FromBody] Event newEvent)
        {
            EventDB.events.Add(newEvent);
            return Ok("Event added.");
        }
      
    }
}