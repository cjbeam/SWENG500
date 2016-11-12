using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Tonal.Model
{
    [DataContract]
    public class State
    {
        [DataMember]
        public int StateId { get; set; }
        [DataMember]
        public string StateName { get; set; }
        [DataMember]
        public string StateCode { get; set; }
    }
}
