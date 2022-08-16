using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace RegexFirstName
{
    class program
    {
        public static void Main(string[] args)
            
        {
            //To Validate First Name


            RegexPattern Rp = new RegexPattern();
            var result = Rp.Validate();
            Console.WriteLine(result);
        }
    }
}
