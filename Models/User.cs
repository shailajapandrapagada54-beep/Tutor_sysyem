using System.ComponentModel.DataAnnotations;
namespace Tutor_System.Models

{
    public class User
    {
        public int UserId { get; set; }
        public int RoleId { get; set; }
        public string FullName { get; set; } = default!;
        public DateTime? DOB { get; set; }
        public string? Gender { get; set; }
        public string Username { get; set; } = default!;
        public string Email { get; set; } = default!;
        public string Phone { get; set; } = default!;
        public byte[] PasswordHash { get; set; } = default!;
        public byte[] PasswordSalt { get; set; } = default!;
        public string? PhotoUrl { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime? UpdatedAt { get; set; }
        public Role Role { get; set; } = default!;
        public Address? Address { get; set; }
        public ICollection<UserSubject> TutorSubjects { get; set; } = new List<UserSubject>();
    }

}
