using Newtonsoft.Json;
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
    public class StatesController : ApiController {
        [ResponseType(typeof(State))]
        // GET api/<controller>
        [System.Web.Http.Cors.EnableCors("*", "*", "*")]
        public IHttpActionResult Get() {
            IHttpActionResult actionResult;

            Tonal.Data.MemberFieldDataService ds = new Tonal.Data.MemberFieldDataService();
            var dt = ds.LookupStateOptions();

            List<State> list = null;
            if(dt != null && dt.Rows.Count > 0) {
                list = new List<State>();
                foreach(DataRow item in dt.Rows) {
                    State listItem = new State() {
                        StateId = (int)item["stateId"],
                        StateCode = (string)item["stateCode"],
                        StateName = (string)item["stateName"]
                    };

                    list.Add(listItem);
                }
            }

            if (list != null) {
                actionResult = Ok(list);
            } else {
                actionResult = StatusCode(HttpStatusCode.NotFound);
            }

            return actionResult;
        }
    }
}