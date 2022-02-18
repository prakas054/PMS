using PMS.BusinessLayer.Repository.Interafce;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMS.BusinessLayer.UnitOfWork.Interface
{
    public interface IUnitOfWork : IDisposable
    {
        IAllergyRepository Allergies { get; set; }
        IRegistrationRepository RegistrationRepo { get; set; }
        int Complete();
    }
}
