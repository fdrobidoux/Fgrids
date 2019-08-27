using System;
using System.Dynamic;

namespace Fgrids.Utils
{
    public class Utils
    {
        public dynamic Employee = new ExpandoObject();

        public Utils()
        {
            Employee.what = "what";
        }
    }
}
