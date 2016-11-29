using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web.Http;
using System.Web.Http.Results;

namespace Tonal.WebService.Members.Tests
{
    [TestClass]
    public class UnitTestProfile
    {
        [TestMethod]
        public void TestGetProfile()
        {
            
            var controller = new Tonal.WebService.Members.Controllers.ProfileController();
            var result = controller.Get("test@email.com");

            Assert.IsNotNull(result);
        }
    }
}
