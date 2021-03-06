using DotnetIntern2021.Basic;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetIntern2021Test.Basic
{
    public class TestExercise2
    {
        private readonly Exercise2 exercise2 = new();

        [TestCase(153,9)]
        [TestCase(6, 6)]
        [TestCase(10, 1)]
        public void TestEx2(int a, int expected)
        {
            Assert.AreEqual(exercise2.SumCS(a), expected);
        }
    }
}
