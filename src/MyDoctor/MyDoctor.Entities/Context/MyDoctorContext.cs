using Microsoft.EntityFrameworkCore;
using MyDoctor.Entities.Configuration;
using MyDoctor.Entities.Model;
using MyDoctor.Entities.Models;

namespace MyDoctor.Entities.Context
{
    public class MyDoctorContext : DbContext
    {
        public MyDoctorContext()
        {
        }

        public MyDoctorContext(DbContextOptions<MyDoctorContext> options) : base(options)
        {
        }

        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<AppointmentType> AppointmentTypes { get; set; }
        public DbSet<DoctorAppointmentType> DoctorAppointmentTypes { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<DoctorSpecialization> DoctorSpecializations { get; set; }
        public DbSet<Specialization> Specializations { get; set; }
        public DbSet<Password> Passwords { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseIdentityAlwaysColumns();

            modelBuilder.EntityConfigure();

            base.OnModelCreating(modelBuilder);
        }
    }
}
