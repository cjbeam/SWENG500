using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using Tonal.Model;

namespace WCFMemberServiceWebRole
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class MemberService : IMemberService
    {
        [OperationContract]
        public bool Create(Member member)
        {
            try
            {
                Tonal.Data.MemberDataService memberDataService = new Tonal.Data.MemberDataService();
                
                //Logic
                var pass = memberDataService.Create(member);
                return pass;
            }
            catch (Exception)
            {
                throw;
            }
        }

        [OperationContract]
        public Tonal.Model.Member Read(string email)
        {
            try
            {
                Tonal.Data.MemberDataService memberDataService = new Tonal.Data.MemberDataService();

                DataTable dt = memberDataService.Read(email);
                Tonal.Model.Member member = new Tonal.Model.Member();
                if (dt != null && dt.Rows.Count > 0)
                {
                    member.birthDate = (DateTime)dt.Rows[0]["birthDate"];
                    member.education = new Tonal.Model.Education();
                    member.education.EducationId = (int)dt.Rows[0]["educationId"];
                    member.education.EducationLevel = (string)dt.Rows[0]["educationLevel"];
                    member.email = email;
                    member.gender = new Tonal.Model.Gender();
                    member.gender.GenderId = (int)dt.Rows[0]["genderId"];
                    member.gender.GenderType = (string)dt.Rows[0]["genderType"];
                    member.memberId = (int)dt.Rows[0]["memberId"];
                    member.state = new Tonal.Model.State();
                    member.state.StateId = (int)dt.Rows[0]["stateId"];
                    member.state.StateCode = (string)dt.Rows[0]["stateCode"];
                    member.state.StateName = (string)dt.Rows[0]["stateName"];
                }

                return member;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
