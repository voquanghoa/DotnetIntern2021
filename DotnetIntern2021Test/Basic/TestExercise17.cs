using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DotnetIntern2021.Basic;
using NUnit.Framework;
namespace DotnetIntern2021Test.Basic
{
    class TestExercise17
    {
        private readonly Exercise17 exercise17 = new();
        [TestCase(10, 11)]
        [TestCase(66, 101)]
        [TestCase(120, 131)]
        public void Test(int n, int m)
        {
            Assert.AreEqual(exercise17.Ex17(n), m);
        }
    }
}
