﻿using RegexOperations.UserRegistrationSystem;
using System;
using System.Windows.Markup;

namespace RegexOperations
{
    public class Program
    {
        static string firstName = "Mukesh";
        static string lastName = "Mukkara";
        static string email = "abc@gmail.com";
        private static string mobile="9098765432";
        static string password = "1234@xyz";
        private static void Main(string[] args)
        {
            UserRegistration validate = new UserRegistration();
            Console.WriteLine(firstName);
            validate.ValidateName(firstName);
            Console.WriteLine(lastName);
            validate.ValidateName(lastName);
            Console.WriteLine(email);
            validate.ValidateEmail(email);
            Console.WriteLine(mobile);
            validate.ValidateMobile(mobile);
            Console.WriteLine(password);
            validate.ValidatePassword(password);
        }
    }
}