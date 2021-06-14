using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DotnetIntern2021;
using NUnit.Framework;
using DotnetIntern2021.Basic;
namespace DotnetIntern2021Test.Basic
{
    public class TestExercise10
    {
        private readonly Exercise10 exercise10 = new();
        [TestCase(8,2)]
        [TestCase(9,2.0801)]
        [TestCase(-25, -2.924)]
        public void Test(double a, double expected)
        {
            Assert.AreEqual(exercise10.CubeRoot(a), expected);
        }
    }
}
