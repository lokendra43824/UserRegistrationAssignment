using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    class Validation
    {

        public bool validateName(string name)
        {
            string pattern = @"(^[A-Z]{1}[a-z]{2,}$)";

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

        public bool validateEmailId(string emailId)
        {
            string pattern = (@"^([a-z][a-z0-9+_-]\.?[a-z0-9]+@([a-z]([a-z0-9-][a-z])\.)([a-z]([a-z0-9-]*[a-z])\.?)([a-z]{2,3})?)$");

            Regex re = new Regex(pattern);
            if (re.IsMatch(emailId))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool validatePhoneNumber(string phoneNumber)
        {
            string pattern = (@"^\+?[0-9]{1,3}\s[0-9]{10}$");

            Regex re = new Regex(pattern);
            if (re.IsMatch(phoneNumber))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}