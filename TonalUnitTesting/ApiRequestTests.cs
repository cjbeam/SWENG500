using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToneReader;

namespace ToneReader.Tests
{
    [TestClass()]
    public class ApiRequestTests
    {
        [TestMethod()]
        public void MakeRequestTest()
        {
           string result = ApiRequest.MakeRequest("hi");
           Assert.IsTrue(true);
        }
    }

}
