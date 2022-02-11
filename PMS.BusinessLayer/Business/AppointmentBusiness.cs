using PMS.BusinessLayer.Business.Interface;
using PMS.DAL;
using PMS.DAL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMS.BusinessLayer.Business
{
    public class AppointmentBusiness : IAppointmentBusiness
    {
        private readonly PMSContext _context;

        public AppointmentBusiness(PMSContext pMSContext)
        {
            _context = pMSContext;
        }

        public List<Appointment> GetAllAppointment()
        {
            List<Appointment> appointments = _context.Appointment.ToList();
            return appointments;
        }
        public Appointment AddAppointment(Appointment appointment)
        {
            var result = _context.Appointment.Add(appointment);
            _context.SaveChanges();

            return appointment;
        }
    }
}
