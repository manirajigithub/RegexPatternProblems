using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace RegexEmail
{
    public class RegexPattern
    {

        /// <summary>
        ///  E.g. abc.xyz@bl.co.in 
        ///  Email has 3 mandatory parts (abc, bl & co)
        ///  2 optional(xyz & in) 
        ///  with precise @ and.positions
        /// </summary>

        string Email = "^[0-9a-zA-Z]+.[a-zA-Z]{0,5}+@[a-zA-Z]{2,3}]+.[a-zA-Z]{2,3}+.[a-zA-Z]{2,4}&";
        string Mail = Console.ReadLine();  
        public bool ValidateMail()
        {
            return Regex.IsMatch(Mail, Email);
        }
    }
}