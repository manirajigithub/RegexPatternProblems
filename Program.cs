using System;

namespace RegexPasswordUC6
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Registration Problem");
            

            //UC6
            Password2 password2 = new Password2();
            Console.WriteLine("Please Enter your password to check");
            var check6 = password2.ValidatePassword2(Console.ReadLine());
            Console.WriteLine(check6);
        }
    }
}
