using System;

namespace RegexPasswordUC8
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Registration Problem");
            /

            //UC8
            Password4 password4 = new Password4();
            Console.WriteLine("Please Enter your password to check");
            var check8 = password4.ValidatePassword4(Console.ReadLine());
            Console.WriteLine(check8);
        }
    }

}