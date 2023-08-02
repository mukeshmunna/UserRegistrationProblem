using System;
using System.Windows.Markup;
using UserRegistrationProblem;

namespace RegexOperations
{
    public class Program
    {
        static string firstName = "Mukesh";

        private static void Main(string[] args)
        {
            UserRegistration validate = new UserRegistration();
            Console.WriteLine(firstName);
            validate.ValidateName(firstName);

        }
    }
}