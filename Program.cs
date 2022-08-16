using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace RegexLastName
{
    class program
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Registraion problem Using Regex");


            //To Validate Last Name

            RegexPattern Rp1 = new RegexPattern();
            var result1 = Rp1.ValidateLast();
            Console.WriteLine(result1);
        }
    }
}

