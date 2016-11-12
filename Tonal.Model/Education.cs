using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Tonal.Model
{
    [DataContract]
    public class Education
    {
        [DataMember]
        public int EducationId { get; set; }
        [DataMember]
        public string EducationLevel { get; set; }
    }
}
