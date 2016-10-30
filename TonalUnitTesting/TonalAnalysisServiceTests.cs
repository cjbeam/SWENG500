﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using TonalService;
using ToneAnalyzer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TonalService.Tests
{
    [TestClass()]
    public class TonalAnalysisServiceTests
    {
        [TestMethod()]
        public void GetAnalysisTest()
        {
            TonalService.TonalAnalysisService service = new TonalService.TonalAnalysisService();
            string results = service.GetAnalysis("DLaustsen@fairhealth.org", "We, therefore, the Representatives of the united States of America, in General Congress, Assembled, appealing to the Supreme Judge of the world for the rectitude of our intentions, do, in the Name, and by Authority of the good People of these Colonies, solemnly publish and declare, That these united Colonies are, and of Right ought to be Free and Independent States, that they are Absolved from all Allegiance to the British Crown, and that all political connection between them and the State of Great Britain, is and ought to be totally dissolved; and that as Free and Independent States, they have full Power to levy War, conclude Peace, contract Alliances, establish Commerce, and to do all other Acts and Things which Independent States may of right do. — And for the support of this Declaration, with a firm reliance on the protection of Divine Providence, we mutually pledge to each other our Lives, our Fortunes, and our sacred Honor.");
            Console.WriteLine(results);
            Assert.IsTrue(true);
        }
    }
}