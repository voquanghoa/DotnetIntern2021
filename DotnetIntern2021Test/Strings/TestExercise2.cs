using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using DotnetIntern2021.Strings;
namespace DotnetIntern2021Test.Strings
{
    class TestExercise2
    {
        private readonly Exercise2 exercise2 = new();
        [TestCase("my_program","MyProgram")]
        [TestCase("hello_world", "HelloWorld")]
        public void Test(string snakeCase, string upperCase)
        {
            Assert.AreEqual(exercise2.Ex2(snakeCase),upperCase);
        }
    }
}
