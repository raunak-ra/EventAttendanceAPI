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
        [HttpPost("add")]
        public object PostSubEvent([FromBody] SubEvent newSubEvent)
        {
            SubEventDB.subEvents.Add(newSubEvent);
            return Ok("SubEvent added.");
        }

        [HttpDelete("delete/{id}")]

        public void Delete(int id)
        {
            var subEvent = SubEventDB.subEvents.FirstOrDefault(sb => sb.Id == id);
            SubEventDB.subEvents.Remove(subEvent);
        }
    }
}