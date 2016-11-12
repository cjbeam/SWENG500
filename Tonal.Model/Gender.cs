using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Tonal.Model
{
    [DataContract]
    public class Gender
    {
        [DataMember]
        public int GenderId { get; set; }
        [DataMember]
        public string GenderType { get; set; }
    }
}
