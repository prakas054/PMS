using PMS.BusinessLayer.Repository.Interafce;
using PMS.DAL;
using PMS.DAL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMS.BusinessLayer.Repository.Classes
{
    public class AppointmentRepository : GenericRepository<Appointment>, IAppointmentRepository
    {
        public AppointmentRepository(PMSContext context) : base(context)
        {
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
