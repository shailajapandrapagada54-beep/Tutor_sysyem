using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tutor_System.Models
{
    public class Address
    {
        public int AddressId { get; set; }
        public int UserId { get; set; }
        public string? HouseBuildingNo { get; set; }
        public string? Floor { get; set; }
        public string? StreetNo { get; set; }
        public string? Area { get; set; }
        public string? Landmark { get; set; }
        public string? PinCode { get; set; }
        public int CountryId { get; set; }
        public int StateId { get; set; }
        public int CityId { get; set; }
        public User User { get; set; } = default!;
    }

}
