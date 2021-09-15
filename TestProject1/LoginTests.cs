using CoreSolution;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Tests
{
    public class LoginTests
    {
        [Fact]
        private void TestRegisterUser()
        {
            LoginManager loginManager = new LoginManager();

            loginManager.RegisterNewUser("user", "pwd");
        }
    }
}
