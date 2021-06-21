using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DotnetIntern2021.Basic;
using NUnit.Framework;

namespace DotnetIntern2021Test.Basic
{
    class TestExercise7
    {
        private readonly Exercise7 exercise7 = new();
        [TestCase(5, 120)]
        [TestCase(9, 362880)]
        [TestCase(1, 1)]
        public void TestEx7(int a, int expected)
        {
            Assert.AreEqual(exercise7.GiaiThua(a), expected);
        }
    }
}
