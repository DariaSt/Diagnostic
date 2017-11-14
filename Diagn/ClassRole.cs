using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diagn
{
   public static class ClassRole
    {
       public static int _role = 1;
       public static int _userID = 0;

        public static int Role
        {
            get => _role;
            set => _role = value;
        }

        public static int _UserID
        {
            get { return _userID; }
            set { _userID = value; }
        }

    }
}
