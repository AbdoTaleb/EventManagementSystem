namespace EventManagementSystem.Models
{
    public class User
    {
        public int Id { get; set; }
        public string FullName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string PasswordHash { get; set; } = string.Empty;

        // Role: Admin, Staff, Attendee
        public string Role { get; set; } = "Attendee";

        // Navigation
        public ICollection<Invitation>? Invitations { get; set; }
    }
}
