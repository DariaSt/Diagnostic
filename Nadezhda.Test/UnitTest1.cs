using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Diagn;

namespace Nadezhda.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodN()
        {
            var runMenu = new patient_registration_menu();

            var trueResu = runMenu.Age(15);
            var falseResu = runMenu.Age(32);

            Assert.IsTrue(trueResu);
            Assert.IsFalse(falseResu);
        }
    }
}
