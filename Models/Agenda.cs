namespace EventManagementSystem.Models
{
    public class Agenda
    {
        public int Id { get; set; }
        public string SessionTitle { get; set; } = string.Empty;
        public string Speaker { get; set; } = string.Empty;
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

        // Foreign Key
        public int EventId { get; set; }
        public Event? Event { get; set; }
    }
}
