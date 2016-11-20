using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tonal.Model {
    public class Registration {
        public string email { get; set; }
        public DateTime birthDate { get; set; }
        public int genderId { get; set; }
        public int stateId { get; set; }
        public int educationId { get; set; }
    }
}
