using Microsoft.EntityFrameworkCore;
using MyDoctor.Entities.Model;
using MyDoctor.Entities.Models;

namespace MyDoctor.Entities.Configuration
{
    public static class EntityConfiguration
    {
        public static void EntityConfigure(this ModelBuilder modelBuilder)
        {
            modelBuilder.CreateAppointmentConfiguration();
            modelBuilder.CreateDoctorConfiguration();
            modelBuilder.CreatePatientConfiguration();
            modelBuilder.CreateSpecializationConfiguration();
            modelBuilder.CreateUserConfiguration();
        }

        private static void CreateAppointmentConfiguration(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Appointment>()
               .HasOne(e => e.Patient)
               .WithMany(e => e.Appointments)
               .HasForeignKey(e => e.PatientId)
               .IsRequired();

            modelBuilder.Entity<Appointment>()
                .HasOne(e => e.DoctorAppointmentType)
                .WithMany(e => e.Appointments)
                .HasForeignKey(e => e.DoctorAppointmentTypeId)
                .IsRequired();
        }

        private static void CreateDoctorConfiguration(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Doctor>()
               .HasOne(e => e.User)
               .WithMany(e => e.Doctors)
               .HasForeignKey(e => e.UserId)
               .IsRequired();

            modelBuilder.Entity<Doctor>()
                .HasMany(e => e.DoctorSpecializations)
                .WithOne(e => e.Doctor)
                .HasForeignKey(e => e.DoctorId)
                .IsRequired();

            modelBuilder.Entity<Doctor>()
                .HasMany(e => e.Reviews)
                .WithOne(e => e.ReviewedDoctor)
                .HasForeignKey(e => e.ReviewdDoctorId)
                .IsRequired();
        }

        private static void CreateSpecializationConfiguration(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Specialization>()
               .HasMany(e => e.DoctorSpecializations)
               .WithOne(e => e.Specialization)
               .HasForeignKey(e => e.SpecializationId)
               .IsRequired();
        }

        private static void CreatePatientConfiguration(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Patient>()
                .HasOne(e => e.User)
                .WithMany(e => e.Patients)
                .HasForeignKey(e => e.UserId)
                .IsRequired();

            modelBuilder.Entity<Patient>()
                .HasMany(e => e.AddedReviews)
                .WithOne(e => e.Reviewer)
                .HasForeignKey(e => e.ReviewerId)
                .IsRequired();

            modelBuilder.Entity<Patient>()
                .HasMany(e => e.Appointments)
                .WithOne(e => e.Patient)
                .HasForeignKey(e => e.PatientId)
                .IsRequired();
        }

        private static void CreateUserConfiguration(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasMany(e => e.Passwords)
                .WithOne(e => e.User)
                .HasForeignKey(e => e.UserId)
                .IsRequired();

            modelBuilder.Entity<User>()
                .HasMany(e => e.Patients)
                .WithOne(e => e.User)
                .HasForeignKey(e => e.UserId)
                .IsRequired();

            modelBuilder.Entity<User>()
                .HasMany(e => e.Doctors)
                .WithOne(e => e.User)
                .HasForeignKey(e => e.UserId)
                .IsRequired();
        }
    }
}
