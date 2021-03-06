﻿using Newtonsoft.Json;
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
    public class GenderOptionsController : ApiController
    {
        [System.Web.Http.Cors.EnableCors("*", "*", "*")]
        [ResponseType(typeof(Gender))]
        public IHttpActionResult Get() {
            IHttpActionResult actionResult;

            Tonal.Data.MemberFieldDataService ds = new Tonal.Data.MemberFieldDataService();
            var dt = ds.LookupGenderOptions();

            List<Gender> list = null;
            if(dt != null && dt.Rows.Count > 0) {
                list = new List<Gender>();
                foreach(DataRow item in dt.Rows) {
                    Gender listItem = new Gender() {
                        GenderId = (int)item["genderId"],
                        GenderType = (string)item["genderType"]
                    };

                    list.Add(listItem);
                }
            }

            if(list != null) {
                actionResult = Ok(list);
            } else {
                actionResult = StatusCode(HttpStatusCode.NotFound);
            }

            return actionResult;
        }
    }
}