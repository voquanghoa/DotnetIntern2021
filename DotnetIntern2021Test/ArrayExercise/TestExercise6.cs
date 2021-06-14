using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using DotnetIntern2021.ArrayExercise;
namespace DotnetIntern2021Test.ArrayExercise
{
    class TestExercise6
    {
        private readonly Exercise6 exercise6 = new();
        [TestCase(new[] { 1, 2, 6, 4, 10 }, 3, -1)]
        [TestCase(new[] { 1, 3, 5, 7, 9 }, 3, 1)]
        public void Test(int[] a, int x, int expected)
        {
            Assert.AreEqual(exercise6.Search(a,x,0,5),expected);
        }
    }
}
