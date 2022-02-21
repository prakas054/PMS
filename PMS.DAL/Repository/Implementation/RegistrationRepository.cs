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
