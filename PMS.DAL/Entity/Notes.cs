using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMS.DAL.Entity
{
    public class Notes
    {
        public int Id { get; set; }
        public int? UserId { get; set; }
        public DateTime? date { get; set; }
        public string Description { get; set; }
    }
}
