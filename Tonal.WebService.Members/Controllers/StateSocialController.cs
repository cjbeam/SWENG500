﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Tonal.WebService.Members.Controllers
{
    [System.Web.Http.Cors.EnableCors("*", "*", "*")]
    public class StateSocialController : ApiController
    {
        [System.Web.Http.Cors.EnableCors("*", "*", "*")]
        [Route("api/state/social")]
        public IHttpActionResult Get()
        {
            IHttpActionResult actionResult;

            Tonal.Data.AnalysisDataService ds = new Tonal.Data.AnalysisDataService();
            var dt = ds.GetAnalysis(Model.Category.social_tone.ToString(), (int)Model.Demographic.state);

            var jsonData = Newtonsoft.Json.JsonConvert.SerializeObject(dt);

            if (jsonData != null)
            {
                actionResult = Ok(jsonData);
            }
            else
            {
                actionResult = StatusCode(HttpStatusCode.NotFound);
            }

            return actionResult;
        }
    }
}