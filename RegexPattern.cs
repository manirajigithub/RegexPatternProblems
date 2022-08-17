using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Registration_Regex
{
    public class RegexPattern
    {
       

        /// <summary>
        /// Password rules 
        /// minimum 8 Characters
        ///  at least 1 Upper Case 
        ///  at least 1 numeric number
        ///  Exactly 1 Special Character
        /// </summary>
        string Password = "^[A-Z]{1}+[a-zA-Z0-9]{8,}+[0-9]{1}+[!@#$%&*]{1}$";
        string Pass = Console.ReadLine();
        public bool ValidatePassword()
        {
            return Regex.IsMatch(Pass, Password);
        }
    }
}

