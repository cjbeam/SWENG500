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
        [ResponseType(typeof(void))]
        public IHttpActionResult Post(Tonal.Model.Member member) {
            IHttpActionResult actionResult;

            try {
                Tonal.Data.MemberDataService memberDataService = new Tonal.Data.MemberDataService();

                //Logic
                var pass = memberDataService.Create(member);
                if(pass) {
                    actionResult = BadRequest();
                } else {
                    actionResult = StatusCode(HttpStatusCode.Created);
                }
            } catch(Exception) {
                throw;
            }

            return actionResult;
        }
    }
}