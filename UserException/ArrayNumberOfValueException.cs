using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace online_application.UserException
{
    class ArrayNumberOfValueException : Exception
    {
        public ArrayNumberOfValueException(string message) : base(message)
        {

        }

        public static string[] checkSizeOfArray(string[] s)
        {
            if (s.Length < 4)
            {
                throw (new ArrayNumberOfValueException("User input missing one or more details"));
            }
            else if (s.Length > 4)
            {
                throw (new ArrayNumberOfValueException("User input exceeds their limit of details"));
            }
            else
            {
                return s;
            }
        }
    }
}
