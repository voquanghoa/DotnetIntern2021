using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DotnetIntern2021.Strings;
using NUnit.Framework;
namespace DotnetIntern2021Test.Strings
{
    class TestExercise1
    {
        private readonly Exercise1 exercise1 = new();
        [TestCase("MyProgram", "my_program")]
        [TestCase("helloWorld", "hello_world")]
        public void Test(string upperCase, string snakeCase)
        {
            Assert.AreEqual(exercise1.snakeCase(upperCase), snakeCase);
        }
    }
}
