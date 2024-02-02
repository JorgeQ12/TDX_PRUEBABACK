using System.ComponentModel.DataAnnotations.Schema;

namespace TdxBackend.DTOs
{
    public class TaskTdxDTO
    {
        public string TaskNameDTO { get; set; }
        public string TaskDescriptionDTO { get; set; }
        public Guid IdStateTaskDTO { get; set; }
    }
}
