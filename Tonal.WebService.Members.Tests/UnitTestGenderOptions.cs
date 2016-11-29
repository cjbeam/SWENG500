using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tonal.WebService.Members.Tests {
    [TestClass]
    public class UnitTestGenderOptions {
        [TestMethod]
        public void TestGetGenderOptions() {
            var controller = new Tonal.WebService.Members.Controllers.GenderOptionsController();
            var result = controller.Get();

            Assert.IsNotNull(result);
        }
    }
}
