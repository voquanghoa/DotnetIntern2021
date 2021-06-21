using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DotnetIntern2021.Strings;
using NUnit.Framework;
namespace DotnetIntern2021Test.Strings
{
    class TestExercise6
    {
        private readonly Exercise6 exercise6 = new();
        [TestCase("abcccceeeeeefd", "abc4e6fd")]
        [TestCase("aaaabbbbccccreeeeeefffffddddddo", "a4b4c4re6f5d6o")]
        [TestCase("aabbbcccc","a2b3c4")]
        public void Test(string s, string expected)
        {
            Assert.AreEqual(exercise6.Ex6(s), expected);
        }
    }
}
