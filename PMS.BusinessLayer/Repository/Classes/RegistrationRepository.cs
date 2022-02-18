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
    public class RegistrationRepository : GenericRepository<Registration>, IRegistrationRepository
    {
        public RegistrationRepository(PMSContext context) : base(context)
        {

        }

        //public void AddRegistration(Registration registration)
        //{
        //    _context.Registration.Add(registration);
        //}

        //public IEnumerable<Registration> GetRegistrations()
        //{
        //    throw new NotImplementedException();
        //}
    }
}
