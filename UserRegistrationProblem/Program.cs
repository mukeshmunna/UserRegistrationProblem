using System;
using System.Windows.Markup;
using UserRegistrationProblem;

namespace RegexOperations
{
    public class Program
    {
        static string firstName = "Mukesh";
        static string lastName = "Mukkara";
        static string email = "abc@gmail.com";

        private static void Main(string[] args)
        {
            UserRegistration validate = new UserRegistration();
            Console.WriteLine(firstName);
            validate.ValidateName(firstName);
            Console.WriteLine(lastName);
            validate.ValidateName(lastName);
            Console.WriteLine(email);
            validate.ValidateEmail(email);

        }
    }
}