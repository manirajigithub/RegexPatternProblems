using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace RegexMobileNumber
{
    public class RegexPattern
    {
        
        /// <summary>
        /// Mobile Format - E.g. 91 9919819801 
        /// Country code followed by space and 10 digit number
        /// </summary>

        string MobileNumber = "^[91]+[]+[6-9]{1}+[0-9]{9}$";
        string Number = Console.ReadLine();

       
        public bool ValidateNumber()
        {
            return Regex.IsMatch(Number, MobileNumber);
        }
    }
}