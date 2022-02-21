using PMS.DAL.Repository.Intreface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMS.DAL.UnitOfWork.Interface
{
    public interface IUnitOfWork : IDisposable
    {
        IAllergyRepository Allergies { get; set; }
        IRegistrationRepository RegistrationRepo { get; set; }

        IAppointmentRepository AppointmentRepository { get; set; }
        int Complete();
    }
}
