using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web.Http;
using System.Web.Http.Results;

namespace Tonal.WebService.Members.Tests
{
    [TestClass]
    public class UnitTestBirthDateEmotion
    {
        [TestMethod]
        public void TestGetBirthDateEmotion()
        {
            
            var controller = new Tonal.WebService.Members.Controllers.BirthDateEmotionController();
            var result = controller.Get();

            Assert.IsNotNull(result);
        }
    }
}
