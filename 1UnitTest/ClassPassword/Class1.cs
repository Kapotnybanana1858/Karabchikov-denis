using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryPassword
{
    public class PasswordChecker
    {
        public static bool ValidatePassword(string Password)
        {
            if (Password.Length < 8 || Password.Length > 20)
                return false;
                if (!Password.Any(Char.IsLower))
                    return false;
            if (!Password.Any(char.IsUpper))
                return false;
            if (!Password.Any(char.IsDigit))
                return false;
            if(Password.Intersect("#$%^&_").Count() == 0)
             return false;
            return true;
        }
    }
}
