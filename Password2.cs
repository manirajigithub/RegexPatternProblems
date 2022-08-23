using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexPassWordUC6
{
    public class Password2
    {
        public static string REGEX_Password2 = "^[A-Z]{1}[A-Z a-z]{7,}$";

        public bool ValidatePassword2(string password)
        {
            return Regex.IsMatch(password, REGEX_Password2);
        }
    }
}
