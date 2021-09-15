using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreSolution
{
    public class LoginManager
    {
        private string _username;
        private string _password;

        public void RegisterNewUser(string username, string password)
        {
            if (_username != username)
            {
                _username = username;
                _password = password;
            }
        }

        public bool DoesUserWithPasswordExist(string username, string password)
        {
            bool userExists = _username == username && _password == password;
            return userExists;
        }
    }
}
