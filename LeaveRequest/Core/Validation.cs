using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeaveRequest.Core
{
    public class Validation
    {
        static MyContext myContext = new MyContext();
        public static bool status;

        public Validation(MyContext context)
        {
            myContext = context;
        }

        public Validation() { }

        public bool validation(MyContext context)
        {
            var result = context.SaveChanges();
            if (result > 0)
            {
                status = true;
            }
            else
            {
                status = false;
            }
            return status;
        }
    }
}
