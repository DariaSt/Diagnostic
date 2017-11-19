using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Diagn;
using Diagn.DiagnosticDataSetTableAdapters;
using System.Data;
using System.Linq;

namespace RedactPatient
{
    [TestClass]
    public class UnitTest1
    {
        int User_id = 5;
        string FirstName = ""; DateTime date = DateTime.Now; string Pass = ""; string Pass2 = ""; int gender = 0;
        string RedactFN = ""; string email = ""; string LN = "";
        [TestMethod]
        public void TestMethodRedact()
        {
            View_UserTableAdapter view = new View_UserTableAdapter();
            FirstName=Select();
            RedactFN = "newName";
            view.Update_User(User_id, RedactFN, LN, gender, date, email, Pass, 2, null);
            
            
            FirstName = Select();
            Assert.IsTrue(FirstName==RedactFN);
           
        }
        public string Select()
        {
            View_UserTableAdapter view = new View_UserTableAdapter();
            var rows = view.GetData().Where(l => l.Id == User_id).ToArray();
            if (rows != null)
            {
                email = rows[0].Email;
                FirstName = rows[0].FirstName;
                LN = rows[0].LastName;
                date = rows[0].DateOfBirth;
                Pass = rows[0].Password;
                Pass2 = rows[0].Password;
                gender = 1;
            }
            return FirstName;
        }
    }
}
