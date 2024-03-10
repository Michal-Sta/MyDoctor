using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyDoctor.Entities.Models
{
    public class DoctorSpecialization
    {
        [Required]
        public int DoctorId { get; set; }

        [ForeignKey(nameof(DoctorId))]
        public virtual Doctor Doctor { get; set; }

        [Required]
        public int SpecializationId { get; set; }

        [ForeignKey(nameof(SpecializationId))]
        public virtual Specialization Specialization { get; set; }
    }
}