using Microsoft.VisualStudio.TestTools.UnitTesting;



namespace TonalService.Tests
{
    [TestClass()]
    public class TonalAnalysisServiceTests
    {
        [TestMethod()]
        public void GetAnalysisTest()
        {
            TonalUnitTesting.RemoteTonalService.TonalAnalysisServiceClient service = new TonalUnitTesting.RemoteTonalService.TonalAnalysisServiceClient();
            string results = service.GetAnalysis("yo@2livecrew.com", @"The frequency with which scientists fabricate and falsify data, or commit other forms of scientific misconduct is a matter of controversy. Many surveys have asked scientists directly whether they have committed or know of a colleague who committed research misconduct, but their results appeared difficult to compare and synthesize. This is the first meta-analysis of these surveys.  To standardize outcomes, the number of respondents who recalled at least one incident of misconduct was calculated for each question, and the analysis was limited to behaviours that distort scientific knowledge: fabrication, falsification, “cooking” of data, etc… Survey questions on plagiarism and other forms of professional misconduct were excluded.The final sample consisted of 21 surveys that were included in the systematic review, and 18 in the meta - analysis.");
            Assert.IsTrue(!System.String.Equals(results, "Body is not large enough to perform analysis."));
        }

        [TestMethod()]
        public void GetAnalysisTestShortMessage()
        {
            TonalUnitTesting.RemoteTonalService.TonalAnalysisServiceClient service = new TonalUnitTesting.RemoteTonalService.TonalAnalysisServiceClient();
            string results = service.GetAnalysis("yo@2livecrew.com", @"The frequency with which scientists");
            System.Diagnostics.Debug.WriteLine(results);
            Assert.IsTrue(System.String.Equals(results, "Body is not large enough to perform analysis."));
        }
    }
}