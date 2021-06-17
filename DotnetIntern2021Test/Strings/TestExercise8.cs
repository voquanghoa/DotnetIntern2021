using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DotnetIntern2021.Strings;
using NUnit.Framework;
namespace DotnetIntern2021Test.Strings
{
    class TestExercise8
    {
        private readonly Exercise8 exercise8 = new();
        [TestCase("aaaabbbbbcccc","abc")]
        [TestCase("hhhhiiiiieeeeeuuuuu","hieu")]
        public void Test(string s,string expected)
        {
            Assert.AreEqual(exercise8.Ex8(s), expected);
        }
    }
}
