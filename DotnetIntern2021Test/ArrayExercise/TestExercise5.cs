using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using DotnetIntern2021.ArrayExercise;

namespace DotnetIntern2021Test.ArrayExercise
{
    class TestExercise5
    {
        private readonly Exercise5 exercise5 = new();
        [TestCase(new[] { 12, 13, 1, 5, 4, 7, 8, 10, 10, 11 }, new[] {4, 7, 8, 10})]
        [TestCase(new[] { 12, 5, 1, 3, 4, 7, 8, 10, 10, 11, 12, 13, 14 }, new[] { 1, 3, 4, 7, 8, 10 })]
        public void Test(int[] a, int[] expected)
        {
            Assert.AreEqual(exercise5.SubArray(a), expected);
        }
    }
}
