using PMS.DAL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PMS.WebApi.Services.Interface
{
    public interface IAppointmentService
    {
        List<Appointment> GetAllAppointment();
        //Appointment GetAppointmentById(int id);
        Appointment AddAppointment(Appointment appointment);
        //Appointment UpdateAppointment(Appointment appointment);
        //bool DeleteAppointment(int id);
    }
}
