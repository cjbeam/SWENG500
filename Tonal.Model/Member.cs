using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Tonal.Model
{
    [DataContract]
    public class Member
    {
        [DataMember]
        public int memberId { get; set; }
        [DataMember]
        public string email { get; set; }
        [DataMember]
        public DateTime birthDate { get; set; }
        [DataMember]
        public Gender gender { get; set; }
        [DataMember]
        public State state { get; set; }
        [DataMember]
        public Education education { get; set; }
    }
    
}
