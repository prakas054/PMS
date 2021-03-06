using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PMS.BusinessLayer.DTO;
using PMS.DAL.UnitOfWork.Interface;
using PMS.DAL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PMS.BusinessLayer.Business.Interface;

namespace PMS.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppointmentController : ControllerBase
    {
        private readonly IAppointmentBusiness _appointmentBusiness;

        public AppointmentController(IAppointmentBusiness appointmentBusiness)
        {
            _appointmentBusiness = appointmentBusiness;
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                List<AppointmentDTO> appointmentDTOs = _appointmentBusiness.GetAllAppointment().ToList();

                if (!appointmentDTOs.Any())
                {
                    return StatusCode(404, "Not found");
                }

                return Ok(appointmentDTOs);
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
        public IActionResult Post([FromBody] AppointmentDTO appointmentDTO)
        {
            try
            {
                if (appointmentDTO == null)
                {
                    return StatusCode(400);
                }

                _appointmentBusiness.AddAppointment(appointmentDTO);
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
