using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tonal.WebService.Members.Tests {
    [TestClass]
    public class UnitTestEducationLevels {
        [TestMethod]
        public void TestGetEducationLevels() {
            var controller = new Tonal.WebService.Members.Controllers.EducationLevelsController();
            var result = controller.Get();

            Assert.IsNotNull(result);
        }
    }
}
