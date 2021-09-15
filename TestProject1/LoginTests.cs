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
    // TODO testa registrering av flera användare
    // TODO testa att man kan logga in
    // TODO samma kod i varje test för att skapa login manager
    public class LoginTests
    {
        [Fact]
        private void TestRegisterUser()
        {
            LoginManager loginManager = new LoginManager();
            
            Assert.False(loginManager.DoesUserWithPasswordExist("user", "pwd"));

            loginManager.RegisterNewUser("user", "pwd");

            Assert.True(loginManager.DoesUserWithPasswordExist("user", "pwd"));
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
