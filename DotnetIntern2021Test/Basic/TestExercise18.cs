using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DotnetIntern2021.Basic;
using NUnit.Framework;
namespace DotnetIntern2021Test.Basic
{
    class TestExercise18
    {
        private readonly Exercise18 exercise18 = new();
        [TestCase(19, true)]
        [TestCase(17, false)]
        [TestCase(32, true)]
        [TestCase(7, true)]
        [TestCase(20, false)]
        [TestCase(145, false)]
        public void TestEx18(int a, bool expected)
        {
            Assert.AreEqual(exercise18.HappyNumber(a), expected);
        }
    }
}
