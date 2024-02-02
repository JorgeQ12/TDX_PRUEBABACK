using System.ComponentModel.DataAnnotations;

namespace TdxBackend.Domain.Entities
{
    public class StateTask
    {
        [Key]
        public Guid ID { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }

    }
}
