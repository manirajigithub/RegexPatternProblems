
using Registration_Regex;

namespace RegexPassWord
{
    class program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Registraion problem Using Regex");

            //To Validate Password

            RegexPattern Rp4 = new RegexPattern();
            var result4 = Rp4.ValidatePassword();
            Console.WriteLine(result4);
            Console.WriteLine("------------------------------------------");
        }
    }
}
