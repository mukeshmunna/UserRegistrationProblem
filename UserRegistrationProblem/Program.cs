using System;
using System.Windows.Markup;
using UserRegistrationProblem;

namespace RegexOperations
{
    public class Program
    {
        static string firstName = "Mukesh";
        static string lastName = "Mukkara";

        private static void Main(string[] args)
        {
            UserRegistration validate = new UserRegistration();
            Console.WriteLine(firstName);
            validate.ValidateName(firstName);
            Console.WriteLine(lastName);
            validate.ValidateName(lastName);

        }
    }
}