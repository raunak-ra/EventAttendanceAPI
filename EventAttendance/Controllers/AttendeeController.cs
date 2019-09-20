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
    [Route("api/event/subevent/")]
    [ApiController]
    public class AttendeeController : ControllerBase
    {
        [HttpGet("attendee")]
        public List<Attendee> GetAllAttendees()
        {
            return AttendeeDB.attendees;
        }

        [HttpGet("attendee/{id}")]
        public IEnumerable<Attendee> GetAttendeeById(int id)
        {

            var attendee = AttendeeDB.attendees.Where(a => a.Id == id);
            return attendee;
        }


        [HttpGet("{sid}/attendee")]
        public List<Attendee> GetAttendeeBySubEventId(int sid)
        {

            var attendee = SubEventDB.subEvents.First(s => s.Id == sid).Attendees;
            return attendee;
        }
        [HttpPut("{sid}/attendee")]
        public object PostAttendee(int sid, [FromBody] Attendee newAttendee)
        {
            SubEventDB.subEvents[sid].Attendees.Add(newAttendee);
            return Ok("Attendee added.");
        }

        [HttpPut("attendee/{id}/present")]
        public ActionResult<Object> PutPresent(int id)
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
            attendee.IsPresent = true;

            return Ok("Marked As Present.");
        }

        [HttpPut("attendee/{id}/absent")]
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

        [HttpDelete("attendee/{id}")]
        public ActionResult<Object> Delete(int id)
        {
            try
            {
                var attendee = AttendeeDB.attendees.FirstOrDefault(e => e.Id == id);
                AttendeeDB.attendees.Remove(attendee);
            }
            catch (Exception e)
            {
                return BadRequest("Invalid Request" + e.Message);
            }

            return Ok("Deleted Successfully.");
        }
    }
}