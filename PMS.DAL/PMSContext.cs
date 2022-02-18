using Microsoft.EntityFrameworkCore;
using PMS.DAL.Entity;
using System;

namespace PMS.DAL
{
    public class PMSContext : DbContext
    {
        public PMSContext(DbContextOptions<PMSContext> options) : base(options)
        {

        }

        public DbSet<Allergy> Allergy { get; set; }
        public DbSet<Diagnosis> Diagnosis { get; set; }
        public DbSet<DrugData> DrugData { get; set; }
        public DbSet<Procedure> Procedure { get; set; }
        public DbSet<Registration> Registration { get; set; }
        public DbSet<Appointment> Appointment { get; set; }
        public DbSet<Role> Role { get; set; }
        public DbSet<EmergencyContact> EmergencyContact { get; set; }
        public DbSet<Log> Logs { get; set; }
        public DbSet<Notes> Notes { get; set; }
        public DbSet<UserRoles> UserRoles { get; set; }
        public DbSet<UserAddress> UserAddresses { get; set; }
        public DbSet<PatientVisits> PatientVisits { get; set; }
        public DbSet<PatientAllergies> PatientAllergies { get; set; }
        public DbSet<PatientVisitDiagnosis> PatientVisitDiagnoses { get; set; }
        public DbSet<PatientVisitProcedures> PatientVisitProcedures { get; set; }
        public DbSet<PatientVisitMedication> PatientVisitMedications { get; set; }


    }
}
