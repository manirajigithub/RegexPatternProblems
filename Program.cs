using System;

namespace RegexSampleEmails
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Registration Problem");
            
            //UC9
            SampleEmails sampleEmail = new SampleEmails();
            Console.WriteLine("Please Enter your sample emails to check");
            var check9 = sampleEmail.ValidateEmail(Console.ReadLine());
            Console.WriteLine(check9);
        }
    }

}