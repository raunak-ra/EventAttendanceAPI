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

        [HttpPost("add")]
        public object PostAttendee([FromBody] Attendee newAttendee)
        {
            AttendeeDB.attendees.Add(newAttendee);
            return Ok("Attendee added.");
        }

        [HttpPut("present/{id}")]
        public ActionResult<Object> Put(int id)
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

        [HttpPut("absent/{id}")]
        public ActionResult<Object> Put(int id)
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

            return Ok("Deleted Successfully.")
        }
    }
}