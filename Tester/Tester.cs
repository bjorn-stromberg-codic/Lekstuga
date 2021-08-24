using System;
using System.Diagnostics;
using Xunit;

namespace Tester
{
    public class Tester
    {
        [Fact]
        public void AlwaysSucceed()
        {
            Assert.True(true);
            Assert.Equal(2, 2);
        }
        [Fact]
        public void AlwaysFail()
        {
            Assert.True(false);
        }

        [Fact]
        public void TestaVariabler()
        {
            string name;
            bool lever = false;

            if (lever)
            {
                name = "Mr Smith";
            }
            else
            {
                name = "Bj�rn Str�mberg Per Gunnar";
            }

            Assert.Equal("Bj�rn Str�mberg Per Gunnar", name);
        }
    }
}
