using RegexOperations.UserRegistrationSystem;
using System;
using System.Windows.Markup;

namespace RegexOperations
{
    public class Program
    {
        /*
        static string firstName = "Mukesh";
        static string lastName = "Mukkara";
        private static string mobile="9098765432";
        static string password = "1234@xyz";
        */
        static string email = "abc@gmail.com";
        
        private static void Main(string[] args)
        {
            UserRegistration validate = new UserRegistration();
            /*    Console.WriteLine(firstName);
                validate.ValidateName(firstName);
                Console.WriteLine(lastName);
                validate.ValidateName(lastName);
                 Console.WriteLine(mobile);
                validate.ValidateMobile(mobile);
                Console.WriteLine(password);
                validate.ValidatePassword(password);*/
            Console.WriteLine(email);
            validate.ValidateEmail(email);
            
        }
    }
}