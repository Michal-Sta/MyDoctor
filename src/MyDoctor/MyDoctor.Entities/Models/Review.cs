using MyDoctor.Entities.BaseEntities;
using MyDoctor.Entities.Enums;
using MyDoctor.Entities.Model;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyDoctor.Entities.Models
{
    public class Review : EntityBase
    {
        protected Review()
        {
        }

        public Review(string content, RatingType rating, Patient reviewer, Doctor reviewedDoctor)
        {
            Content = content;
            Rating = rating;
            ReviewerId = reviewer.Id;
            ReviewdDoctorId = reviewedDoctor.Id;
            Reviewer = reviewer;
            ReviewedDoctor = reviewedDoctor;
        }

        [MaxLength(500)]
        public string Content { get; } = string.Empty;

        public RatingType Rating { get; } = RatingType.None;

        [Required]
        public int ReviewerId { get; }

        [Required]
        public int ReviewdDoctorId { get; }

        [ForeignKey(nameof(ReviewerId))]
        public virtual Patient Reviewer { get; }

        [ForeignKey(nameof(ReviewdDoctorId))]
        public virtual Doctor ReviewedDoctor { get; }
    }
}
