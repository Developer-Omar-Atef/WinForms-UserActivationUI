using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A8__Registration_UI
{
    public class Utilities
    {
        public class Entity
        {
            public string UserName { get; set; }
            public string Password { get; set; }
        }

        public static bool ValidatePassword(string password)
        {
            return password.Length >= 8 &&
                   password.Any(char.IsUpper) &&
                   password.Any(char.IsDigit);
        }

    }
}
