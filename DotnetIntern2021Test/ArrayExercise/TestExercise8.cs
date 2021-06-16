using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DotnetIntern2021.ArrayExercise;
using NUnit.Framework;
namespace DotnetIntern2021Test.ArrayExercise
{
    class TestExercise8
    {
        private readonly Exercise8 exercise8 = new();
        [TestCase(new int[] { 1, 3, 6, 10, 15, 21}, 3)]
        public void Test(int[] a, int expected)
        {
            Assert.AreEqual(exercise8.Count(a), expected);
        }
    }
}
