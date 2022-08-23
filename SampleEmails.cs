﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexSampleEmails
{
    public class SampleEmails
    {
        public static string REGEX_SampleEmails = @"^[0-9A-Za-z]+([._+-][0-9A-Za-z]+)*[@][0-9A-Za-z]+.[a-zA-Z]{2,3}(.[a-zA-Z]{2,3})?$";

        public bool ValidateEmail(string email)
        {
            return Regex.IsMatch(email, REGEX_SampleEmails);
        }
    }
}