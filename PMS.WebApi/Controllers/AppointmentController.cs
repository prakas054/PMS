using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PMS.DAL.Entity;
using PMS.WebApi.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PMS.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppointmentController : ControllerBase
    {
        private readonly IAppointmentService _appointmentService;

        public AppointmentController(IAppointmentService appointmentService)
        {
            _appointmentService = appointmentService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                List<Appointment> appointments = _appointmentService.GetAllAppointment();

                if (!appointments.Any())
                {
                    return StatusCode(404, "Not found");
                }

                return Ok(appointments);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        //[HttpGet("{id}")]
        //public IActionResult Get(int id)
        //{
        //    try
        //    {
        //        AppointmentTB appointment = _context.AppointmentTb.FirstOrDefault(x => x.Appointment_Id == id);

        //        if (appointment == null)
        //        {
        //            return StatusCode(404, "Not found");
        //        }

        //        return Ok(appointment);
        //    }
        //    catch (Exception ex)
        //    {
        //        return StatusCode(500, ex.Message);
        //    }
        //}

        [HttpPost]
        public IActionResult Post([FromBody] Appointment appointment)
        {
            try
            {
                var result = _appointmentService.AddAppointment(appointment);

                //if (addedRegistration == null)
                //{
                //    return StatusCode(400);
                //}

                return StatusCode(201);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        //[HttpPut("{id}")]
        //public IActionResult Put(int id, [FromBody] AppointmentTB appointment)
        //{
        //    if (id != appointment.Appointment_Id)
        //    {
        //        return BadRequest();
        //    }
        //    try
        //    {
        //        _context.Entry(appointment).State = EntityState.Modified;
        //        _context.SaveChanges();

        //        return StatusCode(202, "Updated");
        //    }
        //    catch (Exception ex)
        //    {
        //        return StatusCode(500, ex.Message);
        //    }
        //}

        //[HttpDelete("{id}")]
        //public IActionResult Delete(int id)
        //{
        //    try
        //    {

        //        AppointmentTB appointmentFromDB = _context.AppointmentTb.Find(id);
        //        if (appointmentFromDB == null)
        //        {
        //            return NotFound();
        //        }
        //        _context.AppointmentTb.Remove(appointmentFromDB);
        //        _context.SaveChanges();
        //        return StatusCode(200, "Deleted");
        //    }
        //    catch (Exception ex)
        //    {
        //        return StatusCode(500, ex.Message);
        //    }
        //}
    }
}
