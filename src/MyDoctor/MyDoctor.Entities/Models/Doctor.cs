using MyDoctor.Entities.BaseEntities;
using MyDoctor.Entities.Enums;
using MyDoctor.Entities.Model;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyDoctor.Entities.Models
{
    public class Doctor : PersonBase
    {
        protected Doctor()
        {
        }

        public Doctor(User user, string firstName, string lastName, DateTime? birthDate, PersonType type = PersonType.Me) : base(firstName, lastName, birthDate, type)
        {
            UserId = user.Id;
            User = user;
        }

        [MaxLength(500)]
        public string AboutMe { get; } = string.Empty;

        [MaxLength(500)]
        public string OtherSpecialization { get; } = string.Empty;

        public virtual ICollection<DoctorSpecialization> DoctorSpecializations { get; }

        [Required]
        public int UserId { get; }

        [ForeignKey(nameof(UserId))]
        public virtual User User { get; }
        public virtual ICollection<Review> Reviews{ get; }

    }
}