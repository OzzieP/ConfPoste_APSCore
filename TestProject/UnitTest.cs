using ConfPoste_ASPCore.Models;

using System;

using Xunit;

namespace TestProject
{
    public class UnitTest
    {
        [Fact]
        public void Test1()
        {
            string hello = DatabaseHelper.GetHelloWorld();

            Assert.Equal("Hello World!", hello);
        }
    }
}
