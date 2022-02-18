using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMS.DAL.Entity
{
    public class PatientAllergies
    {
        [Key]
        public int Patient_Allergy_Id { get; set; }

        public int? Allergy_Id { get; set; }

        public string Allergy_Type { get; set; }

        public bool? Is_Allergy_Fatal { get; set; }

        public string Description { get; set; }

        public int? UserId { get; set; }
    }
}
