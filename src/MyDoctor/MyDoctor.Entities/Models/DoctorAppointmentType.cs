using MyDoctor.Entities.Model;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyDoctor.Entities.Models
{
    public class DoctorAppointmentType
    {
        [Required]
        public int DoctorId { get; set; }

        [ForeignKey(nameof(DoctorId))]
        public virtual Doctor Doctor { get; set; }

        [Required]
        public int AppointmentTypeId { get; set; }

        [ForeignKey(nameof(AppointmentTypeId))]
        public virtual AppointmentType AppointmentType { get; set; }

        public string Description { get; set; } = string.Empty;

        public int Cost { get; set; }
    }
}
