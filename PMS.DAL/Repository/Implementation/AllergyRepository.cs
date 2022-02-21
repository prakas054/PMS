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
    public class AllergyRepository : GenericRepository<Allergy>, IAllergyRepository
    {
        public AllergyRepository(PMSContext context): base(context)
        {

        }
        public IEnumerable<Allergy> GetAllergies(int count)
        {
            return _context.Allergy.OrderByDescending(d => d.Allergy_Id).Take(count).ToList();
        }
    }
}
