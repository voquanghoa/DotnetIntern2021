using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DotnetIntern2021.Basic;
using NUnit.Framework;
namespace DotnetIntern2021Test.Basic
{
    public class testExercise15
    {
        private readonly Exercise15 exercise15 = new();
        [TestCase(7,4)]
        [TestCase(1,1)]
        [TestCase(-2, 0)]
        [TestCase(120, 199)]
        public void test(int a, int expected)
        {
            Assert.AreEqual(exercise15.findDigits(a), expected);
        }
    }
}
