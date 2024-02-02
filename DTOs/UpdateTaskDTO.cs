namespace TdxBackend.DTOs
{
    public class UpdateTaskDTO
    {
        public Guid IDDTO {  get; set; } 
        public string TaskNameDTO { get; set; }
        public string TaskDescriptionDTO { get; set; }
        public Guid IdStateTaskDTO { get; set; }
    }
}
