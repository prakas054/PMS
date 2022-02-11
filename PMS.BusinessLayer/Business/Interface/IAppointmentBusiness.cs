using PMS.DAL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMS.BusinessLayer.Business.Interface
{
    public interface IAppointmentBusiness
    {
        List<Appointment> GetAllAppointment();
        Appointment AddAppointment(Appointment appointment);
    }
}
