using MyDoctor.Entities.BaseEntities;

namespace MyDoctor.Entities.Models
{
    public class Specialization : EntityBase
    {
        public Specialization(string title, string code)
        {
            Title = title;
            Code = code;
        }

        protected Specialization()
        {
        }

        public string Title { get; }
        public string Code { get; }
        public virtual ICollection<DoctorSpecialization> DoctorSpecializations { get; }
    }
}
