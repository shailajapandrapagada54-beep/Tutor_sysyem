namespace Tutor_System.Models
{


    public class ApplicationUser : IdentityUser
    {
        [Required, StringLength(120)]
        public string FullName { get; set; } = default!;

        [DataType(DataType.Date)]
        public DateTime? DateOfBirth { get; set; }

        public Gender Gender { get; set; } = Gender.Unspecified;

        // Address
        [StringLength(50)] public string? HouseOrBuildingNo { get; set; }
        [StringLength(50)] public string? Floor { get; set; }
        [StringLength(50)] public string? StreetNo { get; set; }
        [StringLength(120)] public string? Area { get; set; }
        [StringLength(120)] public string? Landmark { get; set; }
        [StringLength(12)] public string? PinCode { get; set; }

        // Location (FKs)
        public int? CountryId { get; set; }
        public int? StateId { get; set; }
        public int? CityId { get; set; }
        public Country? Country { get; set; }
        public State? State { get; set; }
        public City? City { get; set; }

        public string? PhotoPath { get; set; }  // stored path under wwwroot/uploads

        public RoleType Role { get; set; }      // Tutor or Student

        // Navigation: subjects (only relevant if Tutor)
        public ICollection<UserSubject> UserSubjects { get; set; } = new List<UserSubject>();
    }
}
