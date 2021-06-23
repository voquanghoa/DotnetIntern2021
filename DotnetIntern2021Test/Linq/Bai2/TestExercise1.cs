using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DotnetIntern2021.Linq.Bai2;
using NUnit.Framework;

namespace DotnetIntern2021Test.Linq.Bai2
{
    class TestExercise1
    {
        private readonly Exercise1 exercise1 = new();
        [Test]
        public void TestEx01()
        {
            var answer = new List<int>()
            {
                7, 6, 5
            };
            Assert.AreEqual(exercise1.ThreeBiggestNumbers(), answer);
        }
    }
}
