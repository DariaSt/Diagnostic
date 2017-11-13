using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Diagn;

namespace Sagan.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodS()
        {
            var runMenu = new patient_registration_menu();

            var trueResu = runMenu.PassEqual("qwert", "qw");
            var falseResu = runMenu.PassEqual("qwert", "qwert");

            Assert.IsTrue(trueResu);
            Assert.IsFalse(falseResu);
        }
    }
}
