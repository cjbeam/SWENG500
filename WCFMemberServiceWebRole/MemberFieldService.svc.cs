using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.ServiceModel.Web;
using System.Text;
using Tonal.Model;

namespace WCFMemberServiceWebRole
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    [ServiceBehavior(IncludeExceptionDetailInFaults = true)]
    public class MemberFieldService : IMemberFieldService
    {
        public string GetEducationLevels()
        {
            Tonal.Data.MemberFieldDataService ds = new Tonal.Data.MemberFieldDataService();
            var dt = ds.LookupEducationOptions();

            List<Education> list = null;
            if (dt != null && dt.Rows.Count > 0)
            {
                list = new List<Education>();
                foreach (DataRow item in dt.Rows)
                {
                    Education listItem = new Education()
                    {
                        EducationId = (int)item["educationId"],
                        EducationLevel = (string)item["educationLevel"]
                    };

                    list.Add(listItem);
                }
            }

            return JsonConvert.SerializeObject(list);
        }

        public string GetGenderOptions()
        {
            Tonal.Data.MemberFieldDataService ds = new Tonal.Data.MemberFieldDataService();
            var dt = ds.LookupEducationOptions();

            List<Gender> list = null;
            if (dt != null && dt.Rows.Count > 0)
            {
                list = new List<Gender>();
                foreach (DataRow item in dt.Rows)
                {
                    Gender listItem = new Gender()
                    {
                        GenderId = (int)item["genderId"],
                        GenderType = (string)item["genderType"]
                    };

                    list.Add(listItem);
                }
            }

            return JsonConvert.SerializeObject(list);
        }

        public string GetStatesList()
        {
            Tonal.Data.MemberFieldDataService ds = new Tonal.Data.MemberFieldDataService();
            var dt = ds.LookupEducationOptions();

            List<State> list = null;
            if (dt != null && dt.Rows.Count > 0)
            {
                list = new List<State>();
                foreach (DataRow item in dt.Rows)
                {
                    State listItem = new State()
                    {
                        StateId = (int)item["stateId"],
                        StateCode = (string)item["stateName"],
                        StateName = (string)item["stateCode"]
                    };

                    list.Add(listItem);
                }
            }

            return JsonConvert.SerializeObject(list);
        }
    }
}
