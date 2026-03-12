using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tutor_System.Models
{
    public class State
    { public int StateId { get; set; } 
        public int CountryId { get; set; }
        public string Name { get; set; } = default!;
        public Country Country { get; set; } = default!; 
    }
}
