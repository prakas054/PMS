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
