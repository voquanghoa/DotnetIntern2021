using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DotnetIntern2021.Basic;
using NUnit.Framework;
namespace DotnetIntern2021Test.Basic
{
    public class TestExercise14

    {
        private readonly Exercise14 exercise14 = new();
        [TestCase(5, 1)]

        [TestCase(13, 2)]
        [TestCase(4, 0)]
        public void test(int a, int expected)
        {
            Assert.AreEqual(exercise14.count(a), expected);
        }
    }
}
