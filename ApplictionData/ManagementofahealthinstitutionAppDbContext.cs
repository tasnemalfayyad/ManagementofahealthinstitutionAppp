using Domain;
using Microsoft.EntityFrameworkCore;

namespace ApplictionData
{
    public class ManagementofahealthinstitutionAppDbContext:DbContext
    {
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Billing> Billings { get; set; }
        public DbSet<Clinician> Clinicians { get; set; }
        public DbSet<Patient> Patients { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog=M_App_ManagementofHealth");
        }
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Appointment>()
        //         .HasOne(c => c.Clinician)
        //         .WithMany(a => a.Appointments)
        //         .HasForeignKey(c => c.ClinicianId);
        //    modelBuilder.Entity<Appointment>()
        //       .HasOne(p => p.Patient)
        //       .WithMany(a => a.Appointments)
        //       .HasForeignKey(p => p.PatientId);

        //}
    }
}
