using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DotnetIntern2021.ArrayExercise;
using NUnit.Framework;
namespace DotnetIntern2021Test.ArrayExercise
{
    class TestExercise3
    {
        private readonly Exercise3 exercise3 = new();
        [TestCase(new[] { 1, 2, 3, 4, 5, 6 },3)]
        [TestCase(new[] { 10, 12, 14 }, 36)]
        [TestCase(new[] { 3, 5, 7 }, -15)]
        public void TestEx3(int[] a, int expected)
        {
            Assert.AreEqual(exercise3.Ex3(a), expected);
        }
    }
}
