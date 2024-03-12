using MyDoctor.Entities.Enums;
using System.ComponentModel.DataAnnotations;

namespace MyDoctor.Entities.BaseEntities
{
    public class PersonBase : EntityBase
    {
        protected PersonBase()
        {
        }

        public PersonBase(string firstName, string lastName, DateTime? birthDate, PersonType type = PersonType.Me)
        {
            FirstName = firstName;
            LastName = lastName;
            BirthDate = birthDate;
            Type = type;
        }

        [MaxLength(255)]
        public string FirstName { get; }

        [MaxLength(255)]
        public string LastName { get; }

        public DateTime? BirthDate { get; }

        public PersonType Type { get; }
    }
}
