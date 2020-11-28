using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistrationAssn
{
    public static Func<string, string, bool> validate = (name, pattern) =>
    {

        Regex re = new Regex(pattern);
        if (re.IsMatch(name))
        {
            return true;
        }
        else
        {
            return false;
        }

    }
}