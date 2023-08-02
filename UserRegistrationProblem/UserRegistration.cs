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
    }
}
