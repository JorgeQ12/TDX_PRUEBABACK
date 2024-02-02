using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TdxBackend.Domain.Entities
{
    public class TaskTdx
    {
        [Key]
        public Guid ID { get; set; }
        public string TaskName { get; set; }
        public string TaskDescription { get; set; }
        [ForeignKey("StateTask")]
        public Guid IdStateTask { get; set; }
        public DateTime DateRegister { get; set; }

        public virtual StateTask StateTask { get; set; }
    }
}
