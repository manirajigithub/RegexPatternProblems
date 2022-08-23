using System;

namespace RegexPasswordUC7
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Registration Problem");
            
            //UC7
            Password3 password3 = new Password3();
            Console.WriteLine("Please Enter your password to check");
            var check7 = password3.ValidatePassword3(Console.ReadLine());
            Console.WriteLine(check7);
        }
    }
}