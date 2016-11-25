using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using Tonal.Model;

namespace Tonal.WebService.Members.Controllers
{
    [System.Web.Http.Cors.EnableCors("*", "*", "*")]
    public class ProfileController : ApiController
    {
        [System.Web.Http.Cors.EnableCors("*", "*", "*")]
        [ResponseType(typeof(Member))]
        public IHttpActionResult Get(string email) {
            IHttpActionResult actionResult;

            try {
                Tonal.Data.MemberDataService memberDataService = new Tonal.Data.MemberDataService();

                DataTable dt = memberDataService.Read(email);
                Tonal.Model.Member member = null;
                if(dt != null && dt.Rows.Count > 0) {
                    member = new Tonal.Model.Member();

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

                if (member != null) {
                    actionResult = Ok(member);
                } else {
                    actionResult = StatusCode(HttpStatusCode.NotFound);
                }
            } catch(Exception) {
                throw;
            }

            return actionResult;
        }
    }
}
