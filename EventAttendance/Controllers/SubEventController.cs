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
    public class SubEventController : ControllerBase
    {
        [HttpGet]
        public List<SubEvent> GetAllEvents()
        {
            return SubEventDB.subEvents;
        }

        [HttpGet("{id}")]
        public IEnumerable<SubEvent> GetSubEventById(int id)
        {
            var subEvent = SubEventDB.subEvents.Where(sb => sb.Id == id);
            return subEvent;
        }
        [HttpPut("{id}")]
        public object PostSubEvent(int id, [FromBody] SubEvent newSubEvent)
        {
            EventDB.events[id].SubEvent.Add(newSubEvent);
            return Ok("SubEvent added.");
        }


        [HttpDelete("{id}")]

        public void Delete(int id)
        {
            var subEvent = SubEventDB.subEvents.FirstOrDefault(sb => sb.Id == id);
            SubEventDB.subEvents.Remove(subEvent);
        }
    }
}