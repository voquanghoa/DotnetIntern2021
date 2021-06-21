using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using DotnetIntern2021.ArrayExercise;
namespace DotnetIntern2021Test.ArrayExercise
{
    class TestExercise10
    {
        private readonly Exercise10 exercise10 = new();
        [TestCase(new[] { 1, 2, 3, 9, 25}, 35)]
        [TestCase(new[] { 5, 2, 3}, 0)]
        public void Test(int[] a, int expected)
        {
            Assert.AreEqual(exercise10.Ex10(a), expected);
        }
    }
}
