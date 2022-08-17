using RegexMobileNumber;

namespace RegexMobileNUmber
{
    class program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Registraion problem Using Regex");
            RegexPattern Rp3 = new RegexPattern();
            var result3 = Rp3.ValidateNumber();
            Console.WriteLine(result3);
            Console.WriteLine("------------------------------------------");
        }
    }
}