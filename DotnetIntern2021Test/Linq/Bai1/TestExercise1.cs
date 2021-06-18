using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DotnetIntern2021.Linq.Bai1;
using NUnit.Framework;
namespace DotnetIntern2021Test.Linq.Bai1
{
    class TestExercise1
    {
        private readonly Exercise1 exercise1 = new();
        [TestCase(1,9)]
        [TestCase(2,9.5)]
        [TestCase(3,8.0)]
        [TestCase(4,10.0)]
        public void TestEx1(int id, double expected)
        {
            Assert.AreEqual(exercise1.Score(id), expected);
        }
    }
}
