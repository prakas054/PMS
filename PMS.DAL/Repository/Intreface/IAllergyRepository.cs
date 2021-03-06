using PMS.DAL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMS.DAL.Repository.Intreface
{
    public interface IAllergyRepository : IGenericRepository<Allergy>
    {
        IEnumerable<Allergy> GetAllergies(int count);
    }
}
