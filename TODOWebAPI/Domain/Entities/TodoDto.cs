namespace TODOWebAPI.Domain.Entities
{
    public class TodoDto
    {
        public string ActivityName { get; set; }
        public string Description { get; set; }
        public string Notes { get; set; }
        public string CreatedAt { get; set; }
        public string UserCreated { get; set; }
    }
}
