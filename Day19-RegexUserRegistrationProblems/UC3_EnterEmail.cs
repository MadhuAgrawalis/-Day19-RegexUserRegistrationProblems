using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace ReGex_UserRegistration
{
    public class UC3_EnterEmail
    {
        public string Regex_Pattern = "^[a-zA-Z0-9+_.-]+@[a-zA-Z0-9.-]+$";

        public bool validateEmail(string Email)
        {
            return Regex.IsMatch(Email, Regex_Pattern);
        }
    }
}