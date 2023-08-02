using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistrationProblem
{
    internal class UserRegistration
    {
        string nameRegex = "^[A-Z]{1}[a-z]{2,}$";
        string emailRegex = "^[a-z0-9]{1,}[._+-]{0,1}[a-z0-9]{0,}[@]{1}[a-z0-9]{1,}[.]{1}[a-z]{2,}[.]{0,1}[a-z]{0,}$";

        public void ValidateName(string name)
        {
            if (Regex.IsMatch(name, nameRegex))
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("In valid");
            }
        }
        public void ValidateEmail(string mail)
        {
            if (Regex.IsMatch(mail, emailRegex))
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("In valid");
            }
        }
    }
}
