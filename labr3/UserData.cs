using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labr3
{
    public class UserData
    {
        public string Login { get; set; }
        public bool AuthResult { get; set; }
        public string ErrorMessage { get; set; }

        public UserData(string login, bool authResult, string errorMessage)
        {
            Login = login;
            AuthResult = authResult;
            ErrorMessage = errorMessage;
        }
    }
}
