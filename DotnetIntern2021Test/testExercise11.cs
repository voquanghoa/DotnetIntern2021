using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DotnetIntern2021;
using NUnit.Framework;
namespace DotnetIntern2021Test
{
    class testExercise11
    {
        private readonly Exercise11 exercise11 = new Exercise11();
        [TestCase(10,5)]
        [TestCase(100, 19)]
        public void test(int a, int expected)
        {
            Assert.AreEqual(exercise11.reverse(a), expected);
        }
    }
}
