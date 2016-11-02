using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToneReader;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToneReader.Tests
{
    [TestClass()]
    public class AnalysisProviderTests
    {
        [TestMethod()]
        public void AnalyzeTest()
        {
            AnalysisProvider provider = new AnalysisProvider();
            provider.Analyze("darren.laustsen@gmail.com", "hi");
            Assert.IsFalse(String.IsNullOrEmpty(provider.EmailAnalysis));
        }
    }
}