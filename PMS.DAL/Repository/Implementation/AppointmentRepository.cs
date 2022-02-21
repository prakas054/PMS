using PMS.DAL;
using PMS.DAL.Entity;
using PMS.DAL.Repository.Intreface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMS.DAL.Repository.Implementation
{
    public class AppointmentRepository : GenericRepository<Appointment>, IAppointmentRepository
    {
        public AppointmentRepository(PMSContext context) : base(context)
        {
        }

    }
}
