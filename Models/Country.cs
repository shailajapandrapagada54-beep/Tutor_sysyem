using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tutor_System.Models
{
    public class Country 
    { 
        public int CountryId { get; set; }
        public string CountryCode { get; set; } = default!; 
        public string Name { get; set; } = default!; 
    }
}
