using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DotnetIntern2021.Strings;
using NUnit.Framework;

namespace DotnetIntern2021Test.Strings
{
    class TestExercise5
    {
        private readonly Exercise5 exercise5 = new();
        [TestCase("abcba",true)]
        [TestCase("abcxyzzyxcba", true)]
        [TestCase("abcxyyxcb", false)]
        public void Test(string s, bool expected)
        {
            Assert.AreEqual(exercise5.Palindrome(s), expected);
        }
    }
}
