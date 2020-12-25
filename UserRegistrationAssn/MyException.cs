using System;
using System.Collections.Generic;
using System.Text;

namespace UserRegistrationAssn
{
    class MyException : ApplicationException
    {
        public MyException(string message) : base(message)
        {

        }

    }
}