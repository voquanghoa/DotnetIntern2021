using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DotnetIntern2021.ArrayExercise;
using NUnit.Framework;
namespace DotnetIntern2021Test.ArrayExercise
{
    class TestExercise4
    {
        private readonly Exercise4 exercise4 = new();
        [TestCase(new[] { 1, 2, 3, 4, 5, 6, 11, 15, 17 },38)]
        [TestCase(new[] { 4, 6, 8 }, 0)]
        [TestCase(new[] { 0, 1, 3, 8 }, 3)]
        public void TestEx4(int[] a, int expected)
        {
            Assert.AreEqual(exercise4.Ex4(a), expected);
        }
    }
}
