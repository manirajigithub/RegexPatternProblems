using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using Registration_Regex;
using RegexEmail;

namespace RegexEmail
{
    class program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Registraion problem Using Regex");
            //To Validate Mail

            RegexPattern Rp2 = new RegexPattern();
            var result2 = Rp2.ValidateMail();
            Console.WriteLine(result2);
            Console.WriteLine("------------------------------------------");
        }
    }
}
