using RegexOperations.UserRegistrationSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegistrationProblem
{
    public class Tester
    {
        UserRegistration userRegistration = new UserRegistration();
        public string userdetails(string name, string lname, string email, string phone, string pass)
        {
            if (userRegistration.ValidateName(name)&& (userRegistration.ValidateName(lname))&& (userRegistration.ValidateEmail(email))&& (userRegistration.ValidateMobile(phone))&& (userRegistration.ValidatePassword(pass)))
                    {
                         return "correct";
                    }
            else
                return "incorrect";
        }

    }
}
