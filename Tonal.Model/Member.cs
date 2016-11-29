using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
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

        public Member()
        {
            gender = new Gender();
            state = new State();
            education = new Education();
        }

        public Member(Registration registration)
        {
            email = registration.email;
            birthDate = registration.birthDate;
            gender = new Gender();
            gender.GenderId = registration.genderId;
            state = new State();
            state.StateId = registration.stateId;
            education = new Education();
            education.EducationId = registration.educationId;
        }
    }
}
