using MyDoctor.Entities.Models;
using System.ComponentModel.DataAnnotations;

namespace MyDoctor.Entities.Model
{
    public class Patient : EntityBase
    {
        protected Patient()
        {
        }

        [Required]
        public int UserId { get; }
        public virtual User User { get; set; }
        public virtual ICollection<Review> AddedReviews { get; set; }
        public virtual ICollection<Appointment> Appointments { get; set; }
    }
}
