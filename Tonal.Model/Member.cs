using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tonal.Model
{
    public class Member
    {
        public int memberId { get; set; }
        public string email { get; set; }
        public DateTime birthDate { get; set; }
        public Gender gender { get; set; }
        public State state { get; set; }
        public Education education { get; set; }
    }
    
}
