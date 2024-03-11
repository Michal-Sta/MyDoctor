using MyDoctor.Entities.BaseEntities;
using MyDoctor.Entities.Models.Enums;

namespace MyDoctor.Entities.Models
{
    public class Password : EntityBase
    {
        public Password(string pass)
        {
            Pass = pass;
            PasswordStatus = PasswordStatus.New;
        }

        public PasswordStatus PasswordStatus { get; set; }
        public string Pass { get; }
        public int UserId { get; set; }
        public virtual User User { get; set; }
    }
}