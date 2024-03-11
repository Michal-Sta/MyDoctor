using Microsoft.EntityFrameworkCore;
using MyDoctor.Entities.Model;
using MyDoctor.Entities.Models;
using System.Reflection.Metadata;

namespace MyDoctor.Entities
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
        public DbSet<DoctorSpecialization> DoctorSpecialization { get; set; }
        public DbSet<Specialization> Specializations { get; set; }
        public DbSet<Password> Password { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseIdentityAlwaysColumns();

            modelBuilder.Entity<Appointment>()
                .HasOne(e => e.Patient)
                .WithMany(e => e.Appointments)
                .HasForeignKey(e => e.PatientId)
                .IsRequired();

            modelBuilder.Entity<Appointment>()
               .HasOne(e => e.Doctor)
               .WithMany(e => e.Appointments)
               .HasForeignKey(e => e.DoctorId)
               .IsRequired();

            modelBuilder.Entity<Patient>()
               .HasOne(e => e.User)
               .WithMany(e => e.Patients)
               .HasForeignKey(e => e.UserId)
               .IsRequired();

            modelBuilder.Entity<Doctor>()
               .HasOne(e => e.User)
               .WithMany(e => e.Doctors)
               .HasForeignKey(e => e.UserId)
               .IsRequired();

            base.OnModelCreating(modelBuilder);
        }
    }
}
