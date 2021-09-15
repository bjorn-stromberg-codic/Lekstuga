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

        [Fact]
        private void TestCantRegisterSameUserTwice()
        {
            LoginManager loginManager = new LoginManager();

            loginManager.RegisterNewUser("user", "pwd");
            loginManager.RegisterNewUser("user", "other_pwd");

            Assert.True(loginManager.DoesUserWithPasswordExist("user", "pwd"));
            Assert.False(loginManager.DoesUserWithPasswordExist("user", "other_pwd"));
        }
    }
}
