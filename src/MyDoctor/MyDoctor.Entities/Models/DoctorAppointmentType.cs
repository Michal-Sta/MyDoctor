using MyDoctor.Entities.BaseEntities;
using MyDoctor.Entities.Model;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyDoctor.Entities.Models
{
    public class DoctorAppointmentType : EntityBase
    {
        protected DoctorAppointmentType()
        {
        }

        public DoctorAppointmentType(int doctorId, Doctor doctor, int appointmentTypeId, AppointmentType appointmentType, string description, int cost, ICollection<Appointment> appointments)
        {
            DoctorId = doctorId;
            Doctor = doctor;
            AppointmentTypeId = appointmentTypeId;
            AppointmentType = appointmentType;
            Description = description;
            Cost = cost;
            Appointments = appointments;
        }

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

        public virtual ICollection<Appointment> Appointments { get; set; }
    }
}
