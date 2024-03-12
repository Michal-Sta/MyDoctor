using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyDoctor.Entities.BaseEntities
{
    public abstract class EntityBase
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public Guid Guid { get; set; } = Guid.NewGuid();
        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
        public int CreatedBy { get; set; }
        public bool IsActive { get; set; } = true;
    }
}
