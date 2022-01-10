using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace online_application.UserException
{
    class InputNotstringCharException : Exception
    {
        public InputNotstringCharException(string message) : base(message)
        {

        }

        public static int check(string s)
        {
            int i;
            bool b = int.TryParse(s, out i);
            if (!b)
            {
                throw (new InputNotstringCharException("Input should be int value not string or char"));
            }
            else
            {
                return i;
            }
        }
    }
}
