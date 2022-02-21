using PMS.DAL;
using PMS.DAL.Repository.Implementation;
using PMS.DAL.Repository.Intreface;
using PMS.DAL.UnitOfWork.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMS.DAL.UnitOfWork.Implementation
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly PMSContext _context;
        public UnitOfWork(PMSContext context)
        {
            _context = context;
            Allergies = new AllergyRepository(_context);
            RegistrationRepo = new RegistrationRepository(_context);
            AppointmentRepository = new AppointmentRepository(_context);
        }

        public IAllergyRepository Allergies { get; set; }
        public IRegistrationRepository RegistrationRepo { get; set; }
        public IAppointmentRepository AppointmentRepository { get; set; }

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
