using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DotnetIntern2021.Strings;
using NUnit.Framework;
namespace DotnetIntern2021Test.Strings
{
    class TestExercise7
    {
        private readonly Exercise7 exercise7 = new();
        [TestCase("ab2c", "abbc")]
        [TestCase("ab2c5", "abbccccc")]
        [TestCase("a5b2c5", "aaaaabbccccc")]
        public void Test(string s, string expected)
        {
            Assert.AreEqual(exercise7.Ex7(s), expected);
        }
    }
}
