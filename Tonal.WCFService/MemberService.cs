using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Tonal.Model;

namespace Tonal.WCFService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class MemberService : Tonal.Contract.IMemberService
    {
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

        public string Read(string email)
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

                return JsonConvert.SerializeObject(member);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
