using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Diagn;

namespace PatientRegistration.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodQw()
        {
            var runMenu = new patient_registration_menu();

            var trueResu = runMenu.AddPatient();
           // var falseResu = runMenu.AddPatient();

            Assert.IsTrue(trueResu==1);
            Assert.IsFalse(trueResu!=1);
        }
    }
}
