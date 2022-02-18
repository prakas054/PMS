using PMS.BusinessLayer.Repository.Classes;
using PMS.BusinessLayer.Repository.Interafce;
using PMS.BusinessLayer.UnitOfWork.Interface;
using PMS.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMS.BusinessLayer.UnitOfWork.Class
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly PMSContext _context;
        public UnitOfWork(PMSContext context)
        {
            _context = context;
            Allergies = new AllergyRepository(_context);
            RegistrationRepo = new RegistrationRepository(_context);
        }

        public IAllergyRepository Allergies { get; set; }
        public IRegistrationRepository RegistrationRepo { get; set; }


        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
