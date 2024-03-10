using System.ComponentModel.DataAnnotations;

namespace MyDoctor.Entities.Models
{
    public class User : EntityBase
    {
        public User()
        {
        }

        [MaxLength(255)]
        public string FirstName { get; }

        [MaxLength(255)]
        public string LastName { get; }

        [Required]
        [MaxLength(255)]
        public string Email { get; }

        [MaxLength(100)]
        public string PhoneNumber { get; } = string.Empty;

        public virtual ICollection<Password> Passwords { get; }
    }
}