using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tutor_System.Models
{
    public class City 
    { 
        public int CityId { get; set; } 
        public int StateId { get; set; } 
        public string Name { get; set; } = default!; 
        public State State { get; set; } = default!; 
    }
}
