using MyDoctor.Entities.BaseEntities;
using MyDoctor.Entities.Models;
using MyDoctor.Entities.Models.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyDoctor.Entities.Model
{
    public class Appointment : EntityBase
    {
        protected Appointment()
        {
        }

        [MaxLength(500)]
        public string Comment { get; } = string.Empty;

        public bool IsFirst { get; }

        public AppointmentStatus Status { get; set; } = AppointmentStatus.Requested;

        public DateTime Date { get; }

        [Required]
        public int PatientId { get; }

        [ForeignKey(nameof(PatientId))]
        public virtual Patient Patient { get; }

        [Required]
        public int DoctorId { get; }

        [ForeignKey(nameof(DoctorId))]
        public virtual Doctor Doctor { get; }

        [Required]
        public int DoctorAppointmentTypeId { get; }

        [ForeignKey(nameof(DoctorAppointmentTypeId))]
        public virtual DoctorAppointmentType DoctorAppointmentTypes { get; }
    }
}