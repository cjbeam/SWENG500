using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data;

namespace Tonal.Data.Test
{
    [TestClass]
    public class MemberFieldDataServiceUnitTest
    {
        [TestMethod]
        public void TestLookupEducationOptions()
        {
            //Declare
            Data.MemberFieldDataService memberFieldDataService = new Data.MemberFieldDataService();
            Model.Education educations = new Model.Education();

            //Logic
            var list = memberFieldDataService.LookupEducationOptions();

            //Assert
            Assert.IsNotNull(list);
        }

        [TestMethod]
        public void TestLookupGenderOptions()
        {
            //Declare
            Data.MemberFieldDataService memberFieldDataService = new Data.MemberFieldDataService();
            Model.Gender genders = new Model.Gender();

            //Logic
            var list = memberFieldDataService.LookupGenderOptions();

            //Assert
            Assert.IsNotNull(list);
        }

        [TestMethod]
        public void TestLookupStateOptions()
        {
            //Declare
            Data.MemberFieldDataService memberFieldDataService = new Data.MemberFieldDataService();
            Model.State states = new Model.State();

            //Logic
            var list = memberFieldDataService.LookupStateOptions();

            //Assert
            Assert.IsNotNull(list);
        }
    }
}
