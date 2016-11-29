using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data;

namespace Tonal.Data.Test
{
    [TestClass]
    public class MemberDataServiceUnitTest
    {
        [TestMethod]
        public void TestCreate()
        {
            //Declare
            Data.MemberDataService memberDataService = new Data.MemberDataService();
            Model.Member member = new Model.Member();

            //Mock Data
            member.email = "test@email.com";
            member.birthDate = DateTime.Now;
            member.education = new Model.Education();
            member.education.EducationId = 3;
            member.gender = new Model.Gender();
            member.gender.GenderId = 1;
            member.state = new Model.State();
            member.state.StateId = 47;

            //Logic
            var pass = memberDataService.Create(member);

            //Assert
            Assert.IsTrue(pass);
        }

        [TestMethod]
        public void TestRead()
        {
            //Declare
            Data.MemberDataService memberDataService = new Data.MemberDataService();

            //Mock Data
            var email = "test@email.com";

            //Logic
            DataTable dt = memberDataService.Read(email);
            Model.Member member = new Model.Member();
            if (dt != null && dt.Rows.Count > 0)
            {
                member.birthDate = (DateTime)dt.Rows[0]["birthDate"];
                member.education = new Model.Education();
                member.education.EducationId = (int)dt.Rows[0]["educationId"];
                member.education.EducationLevel = (string)dt.Rows[0]["educationLevel"];
                member.email = email;
                member.gender = new Model.Gender();
                member.gender.GenderId = (int)dt.Rows[0]["genderId"];
                member.gender.GenderType = (string)dt.Rows[0]["genderType"];
                member.memberId = (int)dt.Rows[0]["memberId"];
                member.state = new Model.State();
                member.state.StateId = (int)dt.Rows[0]["stateId"];
                member.state.StateCode = (string)dt.Rows[0]["stateCode"];
                member.state.StateName = (string)dt.Rows[0]["stateName"];
            }

            //Assert
            Assert.IsTrue(member.memberId > 0);
        }
    }
}
