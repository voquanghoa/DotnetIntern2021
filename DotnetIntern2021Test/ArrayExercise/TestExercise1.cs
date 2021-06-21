using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DotnetIntern2021.ArrayExercise;
using NUnit.Framework;
namespace DotnetIntern2021Test.ArrayExercise
{
    class TestExercise1
    {
        private readonly Exercise1 exercise1 = new();
        [TestCase(new[] { 1, 2, 3, 4, 5 }, new int[0])]
        [TestCase(new[] { 1, 1, 1, 2, 3, 4, 5, 6, 6 }, new[] { 1, 6 })]
        public void TestEx1(int[] a, int[] expected)
        {
            Assert.AreEqual(exercise1.Ex1(a), expected);
        }
    }
}
