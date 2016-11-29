using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Tonal.Model
{
    public class Gender
    {
        public int GenderId { get; set; }
        public string GenderType { get; set; }
    }

    public enum GenderEnum
    {
        Male = 1,
        Female = 2
    }
}
