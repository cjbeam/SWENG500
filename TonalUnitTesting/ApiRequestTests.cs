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


        [TestMethod()]
        [ExpectedException(typeof(System.Net.WebException),
    "The remote server returned an error: (401) Unauthorized.")]
        public void MakeBadPasswordRequestTest()
        {
            ServiceConfiguration.Password = "Bad Password";
            string result = ApiRequest.MakeRequest("hi");
        }
    }

}
