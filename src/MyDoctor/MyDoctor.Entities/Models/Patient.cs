using MyDoctor.Entities.BaseEntities;
using MyDoctor.Entities.Model.Enums;
using MyDoctor.Entities.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyDoctor.Entities.Model
{
    public class Patient: PersonBase
    {
        public Patient(User user, string firstName, string lastName, DateTime? birthDate, PersonType type = PersonType.Me) : base(firstName, lastName, birthDate, type)
        {
            UserId = user.Id;
            User = user;
            AddedReviews = new HashSet<Review>();
            Appointments = new HashSet<Appointment>();
        }

        [Required]
        public int UserId { get; }

        [ForeignKey(nameof(UserId))]
        public virtual User User { get; set; }
        public virtual ICollection<Review> AddedReviews { get; set; }
        public virtual ICollection<Appointment> Appointments { get; set; }
    }
}
