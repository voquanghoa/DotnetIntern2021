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
        [TestCase(16, 4.000000000000051, Exercise9.epsilon)]
        [TestCase(9, 3.000000001396984, Exercise9.epsilon)]
        [TestCase(-5, -1, Exercise9.epsilon)]
        public void test(double a, double expected, double epsilon)
        {
            Assert.AreEqual(exercise9.SquareRoot(a, epsilon), expected);
        }
    }
}
