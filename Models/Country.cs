using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tutor_System.Models
{
    public class Country 
    { 
        public int Id { get; set; }
        public string Name { get; set; } = default!;
        public ICollection<State> States { get; set; } = new List<State>();
    }
}
