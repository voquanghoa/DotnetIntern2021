using DotnetIntern2021.Basic;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetIntern2021Test
{
    public class Test
    {
        private readonly Exercise4 exercise4 = new();

        [TestCase(6, new[] { 1, 2, 3, 5 })]
        [TestCase(1, new[] { 1 })]
        [TestCase(13, new[] { 1, 2, 3, 5, 8 })]
        public void TestExercise4(int a, int[] expected)
        {
            Assert.AreEqual(exercise4.fibo(a), expected);
        }
    }
}
