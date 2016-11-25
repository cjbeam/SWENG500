using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Tonal.Model
{
    public class Education
    {
        public int EducationId { get; set; }
        public string EducationLevel { get; set; }
    }

    public enum EducationEnum
    {
    	Highschool = 1,
    	TwoYearCollege = 2,
    	University = 3,
    	PostGraduate = 4,
    	PhDPostDoctoral = 5,
    	Other = 6
    }
}
