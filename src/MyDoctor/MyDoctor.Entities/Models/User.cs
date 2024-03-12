using MyDoctor.Entities.BaseEntities;
using MyDoctor.Entities.Model;
using MyDoctor.Entities.Model.Enums;
using System.ComponentModel.DataAnnotations;

namespace MyDoctor.Entities.Models
{
    public class User : EntityBase
    {
        protected User()
        {
        }

        public User(string email, string phoneNumber, UserType type, ICollection<Password> passwords, ICollection<Patient> patients, ICollection<Doctor> doctors)
        {
            Email = email;
            PhoneNumber = phoneNumber;
            Type = type;
            Passwords = passwords;
            Patients = patients;
            Doctors = doctors;
        }

        [Required]
        [MaxLength(255)]
        public string Email { get; }

        [MaxLength(100)]
        public string PhoneNumber { get; } = string.Empty;

        public UserType Type { get; set; }

        public virtual ICollection<Password> Passwords { get; }

        public virtual ICollection<Patient> Patients { get; }

        public virtual ICollection<Doctor> Doctors { get; }
    }
}