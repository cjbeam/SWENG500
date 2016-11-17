using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using Tonal.Model;

namespace Tonal.WebService.Members.Controllers {
    public class RegistrationController : ApiController {
        //public IHttpActionResult Get(Tonal.Model.Registration registration) {
        //    IHttpActionResult actionResult;

        //    try {
        //        Tonal.Data.MemberDataService memberDataService = new Tonal.Data.MemberDataService();

        //        var member = new Tonal.Model.Member(registration);

        //        var pass = memberDataService.Create(member);
        //        if(pass) {
        //            actionResult = BadRequest();
        //        } else {
        //            actionResult = StatusCode(HttpStatusCode.Created);
        //        }
        //    } catch(Exception) {
        //        throw;
        //    }

        //    return actionResult;
        //}

        public IHttpActionResult Get(string email, string birthDate, int genderId, int educationId, int stateId) {
            IHttpActionResult actionResult;

            Tonal.Model.Registration registration = new Registration();
            registration.email = email;
            registration.birthDate = Convert.ToDateTime(birthDate);
            registration.educationId = educationId;
            registration.genderId = genderId;
            registration.stateId = stateId;

            try {
                Tonal.Data.MemberDataService memberDataService = new Tonal.Data.MemberDataService();

                var member = new Tonal.Model.Member(registration);

                var pass = memberDataService.Create(member);
                if(pass) {
                    actionResult = StatusCode(HttpStatusCode.Created);
                } else {
                    actionResult = BadRequest();
                }
            } catch(Exception) {
                throw;
            }
            return actionResult;
        }
    }
}