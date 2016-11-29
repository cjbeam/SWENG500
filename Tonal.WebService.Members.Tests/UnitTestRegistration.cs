using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web.Http;
using System.Web.Http.Results;

namespace Tonal.WebService.Members.Tests
{
    [TestClass]
    public class UnitTestRegistration
    {
        [TestMethod]
        public void TestRegistration()
        {
            
            var controller = new Tonal.WebService.Members.Controllers.RegistrationController();

            var random = DateTime.Now.Month + DateTime.Now.Day + DateTime.Now.Year + DateTime.Now.ToShortTimeString();
            var result = controller.Get(
                random + "testemail@mail.com",
                "1/1/1977",
                1,
                3,
                33
            );

            Assert.IsNotNull(result);
        }
    }
}
