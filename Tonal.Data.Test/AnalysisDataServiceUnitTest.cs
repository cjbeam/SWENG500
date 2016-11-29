using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tonal.Data.Test
{
    /// <summary>
    /// Summary description for AnalysisDataServiceUnitTest
    /// </summary>
    [TestClass]
    public class AnalysisDataServiceUnitTest
    {
        [TestMethod]
        public void TestGetAnalysisForBirthDate()
        {
            //Declare
            Data.AnalysisDataService dataService = new Data.AnalysisDataService();
            Model.Member member = new Model.Member();
            
            //Logic
            var pass = dataService.GetAnalysis("social_tone", (int)Model.Demographic.birthDate);

            //Assert
            Assert.IsNotNull(pass);
        }

        [TestMethod]
        public void TestGetAnalysisForEducation()
        {
            //Declare
            Data.AnalysisDataService dataService = new Data.AnalysisDataService();
            Model.Member member = new Model.Member();

            //Logic
            var pass = dataService.GetAnalysis("emotion_tone", (int)Model.Demographic.education);

            //Assert
            Assert.IsNotNull(pass);
        }

        [TestMethod]
        public void TestGetAnalysisForGender()
        {
            //Declare
            Data.AnalysisDataService dataService = new Data.AnalysisDataService();
            Model.Member member = new Model.Member();

            //Logic
            var pass = dataService.GetAnalysis("language_tone", (int)Model.Demographic.gender);

            //Assert
            Assert.IsNotNull(pass);
        }

        [TestMethod]
        public void TestGetAnalysisForState()
        {
            //Declare
            Data.AnalysisDataService dataService = new Data.AnalysisDataService();
            Model.Member member = new Model.Member();

            //Logic
            var pass = dataService.GetAnalysis("social_tone", (int)Model.Demographic.state);

            //Assert
            Assert.IsNotNull(pass);
        }
    }
}
