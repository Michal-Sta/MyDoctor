using MyDoctor.Entities.BaseEntities;
using MyDoctor.Entities.Models;

namespace MyDoctor.Entities.Model
{
    public class AppointmentType : EntityBase
    {
        public AppointmentType(string title, string description, int timeInMinutes, int cost)
        {
            Title = title;
            Description = description;
            TimeInMinutes = timeInMinutes;
        }

        protected AppointmentType()
        {
        }

        public string Title { get; }

        public string Description { get; }

        public int TimeInMinutes { get; }

        public virtual ICollection<Appointment> Appointments { get; }

        public virtual ICollection<DoctorAppointmentType> DoctorAppointmentTypes { get; }
    }
}