using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMS.DAL
{
    public class UnitOfWork : IDisposable
    {
        //private PMSContext context = new PMSContext();
        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
