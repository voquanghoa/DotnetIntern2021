using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DotnetIntern2021.Strings;
using NUnit.Framework;
namespace DotnetIntern2021Test.Strings
{
    class TestExercise4
    {
        private readonly Exercise4 exercise4 = new();
        [TestCase("abc 123 def 33 mn 3.221", 380)]
        [TestCase("123 45 ...7", 175)]
        public void Test(string s, int expected)
        {
            Assert.AreEqual(exercise4.SumEx4(s), expected);
        }
    }
}
