using PMS.BusinessLayer.Business.Interface;
using PMS.DAL.Entity;
using PMS.WebApi.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PMS.WebApi.Services
{
    public class AppointmentService : IAppointmentService
    {
        private IAppointmentBusiness _appointmentBusiness;
        public AppointmentService(IAppointmentBusiness appointmentBusiness)
        {
            _appointmentBusiness = appointmentBusiness;
        }
        public List<Appointment> GetAllAppointment()
        {
            List<Appointment> appointments = _appointmentBusiness.GetAllAppointment();   //_dbContext.RegistrationTbs.ToList();
            return appointments;
        }
        //public RegistrationTb GetRegistrationById(int id)
        //{
        //    return _dbContext.RegistrationTbs.FirstOrDefault(x => x.UserId == id);
        //}
        public Appointment AddAppointment(Appointment appointment)
        {
            var result = _appointmentBusiness.AddAppointment(appointment);
            return appointment;
        }
        //public RegistrationTb UpdateRegistration(RegistrationTb registration)
        //{
        //    if (_dbContext.RegistrationTbs.AsNoTracking().FirstOrDefault(x => x.UserId == registration.UserId) != null)
        //    {
        //        _dbContext.Entry(registration).State = EntityState.Modified;  ///todo
        //        _dbContext.SaveChanges();
        //        return registration;
        //    }
        //    return null;
        //}
        //public bool DeleteRegistration(int id)
        //{
        //    RegistrationTb registrationFromDB = _dbContext.RegistrationTbs.AsNoTracking().FirstOrDefault(x => x.UserId == id);
        //    if (registrationFromDB == null)
        //    {
        //        return false;
        //    }
        //    _dbContext.Entry(registrationFromDB).State = EntityState.Deleted;
        //    _dbContext.SaveChanges();
        //    return true;
        //}
    }
}
