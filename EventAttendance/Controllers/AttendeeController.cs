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
    [Route("api/event/subevent/[controller]")]
    [ApiController]
    public class AttendeeController : ControllerBase
    {
        [HttpGet]
        public List<Attendee> GetAllEvents()
        {
            return AttendeeDB.attendees;
        }

        [HttpGet("{id}")]
        public IEnumerable<Attendee> GetAttendeeById(int id)
        {

            var attendee = AttendeeDB.attendees.Where(a => a.Id == id);
            return attendee;
        }


        [HttpGet("subeventid/{id}")]
        public List<Attendee> GetAttendeeBySubEventId(int id)
        {

            var attendee = SubEventDB.subEvents.First(s => s.Id == id).Attendees;
            return attendee;
        }
        [HttpPut("add/{id}")]
        public object PostAttendee(int id, [FromBody] Attendee newAttendee)
        {
            SubEventDB.subEvents[id].Attendees.Add(newAttendee);
            return Ok("Attendee added.");
        }

        [HttpPut("{id}/present")]
        public ActionResult<Object> PutPresent(int id)
        {
            Attendee attendee;

            try
            {
                attendee = AttendeeDB.attendees.FirstOrDefault(e => e.Id == id);
            }
            catch(Exception e)
            {
                return BadRequest("Invalid Request" + e.Message);
            }
            attendee.IsPresent = true;

            return Ok("Marked As Present.");
        }

        [HttpPut("{id}/absent")]
        public ActionResult<Object> PutAbsent(int id)
        {
            Attendee attendee;

            try
            {
                attendee = AttendeeDB.attendees.FirstOrDefault(e => e.Id == id);
            }
            catch (Exception e)
            {
                return BadRequest("Invalid Request" + e.Message);
            }
            attendee.IsPresent = false;

            return Ok("Marked As Absent.");
        }

        [HttpDelete("{id}")]
        public ActionResult<Object> Delete(int id)
        {
            try
            {
                var attendee = AttendeeDB.attendees.FirstOrDefault(e => e.Id == id);
                AttendeeDB.attendees.Remove(attendee);
            }
            catch(Exception e)
            {
                return BadRequest("Invalid Request" + e.Message);
            }

            return Ok("Deleted Successfully.");
        }
    }
}