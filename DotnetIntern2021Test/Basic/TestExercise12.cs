using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DotnetIntern2021.Basic;
using NUnit.Framework;
namespace DotnetIntern2021Test.Basic
{
    class TestExercise12
    {
        private readonly Exercise12 exercise12 = new Exercise12();
        [TestCase(121,121)]
        [TestCase(333,333)]
        [TestCase(2345,5432)]
        public void Test(int a, int expected)
        {
            Assert.AreEqual(exercise12.Palindrome(a), expected);
        }
    }
}
