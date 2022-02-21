using PMS.BusinessLayer.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMS.BusinessLayer.Business.Interface
{
    public interface IAppointmentBusiness
    {
        IEnumerable<AppointmentDTO> GetAllAppointment();

        void AddAppointment(AppointmentDTO appointmentDTO);
    }
}
