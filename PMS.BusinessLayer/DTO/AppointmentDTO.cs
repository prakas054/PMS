using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMS.BusinessLayer.DTO
{
    public class AppointmentDTO
    {
        public int AppointmentId { get; set; }

        public string Title { get; set; }

        public DateTime? AppointmentDate { get; set; }

        public DateTime? AppointmentTime { get; set; }

        public string Reason { get; set; }

        public int? SchedularId { get; set; }

        public int? PhysicianId { get; set; }

        public int? NurseId { get; set; }

        public int? PatientId { get; set; }
    }
}
