using DotnetIntern2021;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetIntern2021Test
{
    public class DemoTest
    {
        private readonly Demo demo = new();

        [Test]
        public void TestSum()
        {
            Assert.AreEqual(demo.Sum(2, 3), 5);
        }

        [TestCase(4, 2, 2)]
        [TestCase(9, 3, 6)]
        public void TestSubstract(int a, int b, int expected)
        {
            Assert.AreEqual(demo.Substract(a, b), expected);
        }

        [TestCase(4, 2, 2, 4)]
        [TestCase(1, 3, 6, 6)]
        public void TestMax(int a, int b, int c, int expected)
        {
            Assert.AreEqual(demo.Max(a, b, c), expected);
        }
    }
}
