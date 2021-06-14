using DotnetIntern2021.Basic;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetIntern2021Test.Basic
{
    public class TestExercise4
    {
        private readonly Exercise4 exercise4 = new();

        [TestCase(6, new[] { 1, 2, 3, 5 })]
        [TestCase(1, new[] { 1 })]
        [TestCase(13, new[] { 1, 2, 3, 5, 8 })]
        public void TestEx4(int a, int[] expected)
        {
            Assert.AreEqual(exercise4.Fibo(a), expected);
        }
    }
}
