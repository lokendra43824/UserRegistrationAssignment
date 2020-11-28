using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistrationAssn
{
    public bool Validate(string name, string pattern)
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