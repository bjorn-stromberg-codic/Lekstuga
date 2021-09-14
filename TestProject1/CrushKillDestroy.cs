using ClassLibrary1;
using System;
using Xunit;

namespace TestProject1
{
    public class CrushKillDestroy
    {
        [Fact]
        public void TwoStringsTest()
        {
            // arrange
            Class1 obj = new Class1();
            string[] strings = {"Hello", "World"};

            // act
            int? lenght = obj.StringLenghts(strings);

            // assert
            Assert.Equal(5 + 5, lenght);
        }

        [Fact]
        public void EmptyArrayTest()
        {
            Class1 obj = new Class1();
            string[] strings = {};

            int? lenght = obj.StringLenghts(strings);

            Assert.Equal(0, lenght);
        }

        [Fact]
        public void NullArrayTest()
        {
            Class1 obj = new Class1();
            string[] strings = null;

            int? lenght = obj.StringLenghts(strings);

            Assert.Null(lenght);
        }

        [Fact]
        public void TwoStringsAndANullTest()
        {
            // arrange
            Class1 obj = new Class1();
            string[] strings = { "Hello", null, "World" };

            // act
            int? lenght = obj.StringLenghts(strings);

            // assert
            Assert.Equal(5 + 5, lenght);
        }
    }
}
