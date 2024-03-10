using System.ComponentModel.DataAnnotations;
using MyDoctor.Entities.Model.Enums;
using MyDoctor.Entities.Models;

namespace MyDoctor.Entities.Model
{
    public class UserRole : EntityBase
    {
        protected UserRole()
        {
        }

        public UserRole(string title, UserType type)
        {
            Title = title;
            Type = type;
        }

        [MaxLength(100)]
        public string Title { get; }
        public UserType Type { get; } = UserType.Patient;
        public virtual ICollection<User> Users { get; set; }
    }
}
