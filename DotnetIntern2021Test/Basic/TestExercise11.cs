using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DotnetIntern2021.Basic;
using NUnit.Framework;
namespace DotnetIntern2021Test.Basic
{
    class TestExercise11
    {
        private readonly Exercise11 exercise11 = new Exercise11();
        [TestCase(10,5)]
        [TestCase(100, 19)]
        public void Test(int a, int expected)
        {
            Assert.AreEqual(exercise11.Reverse(a), expected);
        }
    }
}
