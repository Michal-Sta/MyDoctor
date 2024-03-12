using MyDoctor.Entities.BaseEntities;
using MyDoctor.Entities.Enums;
using MyDoctor.Entities.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyDoctor.Entities.Model
{
    public class Appointment : EntityBase
    {
        protected Appointment()
        {
        }

        public Appointment(string comment, bool isFirst, AppointmentStatus status, DateTime date, int patientId, Patient patient, int doctorAppointmentTypeId, DoctorAppointmentType doctorAppointmentType)
        {
            Comment = comment;
            IsFirst = isFirst;
            Status = status;
            Date = date;
            PatientId = patientId;
            Patient = patient;
            DoctorAppointmentTypeId = doctorAppointmentTypeId;
            DoctorAppointmentType = doctorAppointmentType;
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
        public int DoctorAppointmentTypeId { get; }

        [ForeignKey(nameof(DoctorAppointmentTypeId))]
        public virtual DoctorAppointmentType DoctorAppointmentType { get; }
    }
}