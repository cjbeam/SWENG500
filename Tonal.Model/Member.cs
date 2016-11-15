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

        public Member()
        {
            gender = new Gender();
            state = new State();
            education = new Education();
        }

        public Member(MemberViewModel viewModel)
        {
            email = viewModel.email;
            birthDate = viewModel.birthDate;
            gender = new Gender();
            gender.GenderId = viewModel.genderId;
            state = new State();
            state.StateId = viewModel.stateId;
            education = new Education();
            education.EducationId = viewModel.educationId;
        }
    }

    public class MemberViewModel
    {
        public int memberId { get; set; }
        public string email { get; set; }
        public DateTime birthDate { get; set; }
        public int genderId { get; set; }
        public int stateId { get; set; }
        public int educationId { get; set; }
    }
}
