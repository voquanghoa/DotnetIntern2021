using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using DotnetIntern2021.Basic;

namespace DotnetIntern2021Test.Basic
{
    public class TestExercise9
    {
        private readonly Exercise9 exercise9 = new Exercise9();
        [TestCase(16, 4.000000000000051)]
        [TestCase(9, 3.000000001396984)]
        [TestCase(-5, -1)]
        public void test(double a, double expected)
        {
            Assert.AreEqual(exercise9.SquareRoot(a), expected);
        }
    }
}
