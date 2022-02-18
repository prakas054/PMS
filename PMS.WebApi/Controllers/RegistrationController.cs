using Microsoft.AspNetCore.Mvc;
using PMS.BusinessLayer.UnitOfWork.Interface;
using PMS.DAL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PMS.WebApi.Controllers
{ 
    [Route("api/[controller]")]
    [ApiController]
    public class RegistrationController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public RegistrationController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        // GET: api/<RegistrationController>
        [HttpGet]
        public IActionResult Get()
        {
            var registration = _unitOfWork.RegistrationRepo.GetAll();
            return Ok(registration);
        }

        // GET api/<RegistrationController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<RegistrationController>
        [HttpPost]
        public IActionResult Post([FromBody] Registration registration)
        {
            if (registration == null)
            {
                return BadRequest();
            }

            _unitOfWork.RegistrationRepo.Add(registration);
            _unitOfWork.Complete();
            return Ok(registration.EmployeeId);
        }

        // PUT api/<RegistrationController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<RegistrationController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
