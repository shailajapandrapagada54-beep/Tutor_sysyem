using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tutor_System.Models
{
    public class UserSubject
    {
        public int UserId { get; set; }
        public int SubjectId { get; set; }
        public User User { get; set; } = default!;
        public Subject Subject { get; set; } = default!;
    }

}
