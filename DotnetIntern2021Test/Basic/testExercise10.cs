using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DotnetIntern2021.Basic;
using NUnit.Framework;
namespace DotnetIntern2021Test
{
    class testExercise10
    {
        private readonly Exercise10 exercise10 = new Exercise10();
        [TestCase(8,2)]
        [TestCase(9,2.0801)]
        [TestCase(-25, -2.924)]
        public void test(double a, double expected)
        {
            Assert.AreEqual(exercise10.cubeRoot(a), expected);
        }
    }
}
