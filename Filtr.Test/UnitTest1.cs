using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Diagn;
using Diagn.DiagnosticDataSetTableAdapters;

namespace Filtr.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodFilter()
        {
            var runMenu = new authorization_menu();
            View_UserTableAdapter view = new View_UserTableAdapter();
            
            var trueResu = (int)view.Authorization("elsie.estell@rrg.net", "elsie.estell@rrg.net");
         //   var falseResu = (int)view.Authorization("elsie.estell@rrg.net", "net");

            Assert.AreEqual(trueResu,2);
        }
    }
}
