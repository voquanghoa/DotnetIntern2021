using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DotnetIntern2021.Strings;
using NUnit.Framework;
namespace DotnetIntern2021Test.Strings
{
    class TestExercise3
    {
        private readonly Exercise3 exercise3 = new();
        [TestCase("abcdef","fedcba")]
        [TestCase("","")]
        [TestCase("123xyz","zyx321")]
        public void Test(string s, string ans)
        {
            Assert.AreEqual(exercise3.Reverse(s), ans);
        }
    }
}
