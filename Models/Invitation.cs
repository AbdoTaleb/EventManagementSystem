namespace EventManagementSystem.Models
{
    public class Invitation
    {
        public int Id { get; set; }
        public string Status { get; set; } = "Pending"; // Pending, Accepted, Declined

        // Foreign Keys
        public int EventId { get; set; }
        public Event? Event { get; set; }

        public int UserId { get; set; }
        public User? User { get; set; }
    }
}
