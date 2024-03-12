using MyDoctor.Entities.BaseEntities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyDoctor.Entities.Models
{
    public class DoctorSpecialization : EntityBase
    {
        protected DoctorSpecialization()
        {
        }

        public DoctorSpecialization(int doctorId, Doctor doctor, int specializationId, Specialization specialization)
        {
            DoctorId = doctorId;
            Doctor = doctor;
            SpecializationId = specializationId;
            Specialization = specialization;
        }

        [Required]
        public int DoctorId { get; }

        [ForeignKey(nameof(DoctorId))]
        public virtual Doctor Doctor { get; }

        [Required]
        public int SpecializationId { get; }

        [ForeignKey(nameof(SpecializationId))]
        public virtual Specialization Specialization { get; }
    }
}