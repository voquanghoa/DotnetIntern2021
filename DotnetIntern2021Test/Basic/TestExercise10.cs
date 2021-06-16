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
        [TestCase(8, 2, 0.000001)]
        [TestCase(9, 2.0800838230519045, 0.000001)]
        [TestCase(-25, -2.924017738212866, 0.000001)]
        public void Test(double a, double expected, double epsilon)
        {
            Assert.AreEqual(exercise10.CubeRoot(a,epsilon), expected);
        }
    }
}
