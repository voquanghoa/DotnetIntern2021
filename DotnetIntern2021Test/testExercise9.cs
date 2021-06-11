using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using DotnetIntern2021;

namespace DotnetIntern2021Test
{
    public class testExercise9
    {
        private readonly Exercise9 exercise9 = new Exercise9();
        [TestCase(9, 3)]
        [TestCase(0, 0)]
        [TestCase(-5, -1)]
        public void test(double a, double expected)
        {
            Assert.AreEqual(exercise9.squareRoot(a), expected);
        }
    }
}
