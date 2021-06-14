using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DotnetIntern2021.ArrayExercise;
using NUnit.Framework;
namespace DotnetIntern2021Test.ArrayExercise
{
    class TestExercise2
    {
        private readonly Exercise2 exercise2 = new();
        [TestCase(new[] {1,2,3,4,5,6,7},18)]
        public void TestEx2(int[] a, int expected)
        {
            Assert.AreEqual(exercise2.Ex2(a), expected);
        }
    }
}
