using System;
namespace Regex_Problems
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Welcome to User Registration Regex Problems.");
            Console.WriteLine("Welcome to User Registration Regex Problems.");
            Validation firstName_Validation = new Validation();
            firstName_Validation.ValidateFirstName("Ganga");
            firstName_Validation.ValidateFirstName("ganga");
        }
    }
}