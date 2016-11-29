using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToneAnalyzer;
using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace ToneAnalyzer.Tests
{
    [TestClass()]
    public class HelperTests
    {
        [TestMethod()]
        public void DocumentLevelCategoryScoresTest()
        {
            EmailAnalysis analysis;
            List<string> includedCategories = new List<string>();
            includedCategories.Add("emotion_tone");
            var service = new RemoteTonalService.TonalAnalysisServiceClient();
            string json="";
            json = service.GetAnalysis("freddy@aol.com", @"I know you join me in extending a word of thanks to your families. Joe DeMoss, whose son James is graduating, spoke for many parents when he wrote me a letter about the sacrifices you have made. “Deep inside,” he wrote, “we want to explode with pride at what they are committing to do in the service of our country.” Like several graduates, James is a combat veteran. And I would like to ask all of us here today to stand and pay tribute – not only to the veterans among us, but to the more than 2.5 million Americans who have served in Iraq and Afghanistan, and their families.
It is a particularly useful time for America to reflect on those who have sacrificed so much for our freedom – for you are the first class to graduate since 9/11 who may not be sent into combat in Iraq or Afghanistan. When I first spoke at West Point in 2009, we still had more than 100,000 troops in Iraq. We were preparing to surge in Afghanistan. Our counter-terrorism efforts were focused on al Qaeda’s core leadership. And our nation was just beginning a long climb out of the worst economic crisis since the Great Depression.");
                    analysis = JsonConvert.DeserializeObject<EmailAnalysis>(json);
           var results = Helper.DocumentLevelCategoryScores(analysis,includedCategories);
            Assert.IsTrue(results.Count > 0);
        }
    }
}