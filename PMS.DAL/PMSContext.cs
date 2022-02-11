using Microsoft.EntityFrameworkCore;
using PMS.DAL.Entity;
using System;

namespace PMS.DAL
{
    public class PMSContext : DbContext
    {
        public DbSet<Allergy> Allergy { get; set; }
        public DbSet<Diagnosis> Diagnosis { get; set; }
        public DbSet<DrugData> DrugData { get; set; }
        public DbSet<Procedure> Procedure { get; set; }
        public DbSet<Registration> Registration { get; set; }
        public DbSet<Appointment> Appointment { get; set; }
        public DbSet<Role> Role { get; set; }

        public PMSContext(DbContextOptions<PMSContext> options) : base(options)
        {

        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=PMSData");
        //}
    }
}
