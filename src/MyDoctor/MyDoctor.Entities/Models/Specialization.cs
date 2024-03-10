namespace MyDoctor.Entities.Models
{
    public class Specialization
    {
        public string Title { get; set; }
        public string Code { get; set; }

        public virtual ICollection<DoctorSpecialization> DoctorSpecializations { get; set; }
    }
}
