﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web.Http;
using System.Web.Http.Results;

namespace Tonal.WebService.Members.Tests
{
    [TestClass]
    public class UnitTestEducationSocial
    {
        [TestMethod]
        public void TestGetEducationSocial()
        {
            
            var controller = new Tonal.WebService.Members.Controllers.EducationSocialController();
            var result = controller.Get();

            Assert.IsNotNull(result);
        }
    }
}
