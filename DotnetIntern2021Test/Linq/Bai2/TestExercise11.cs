using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DotnetIntern2021.Linq.Bai2;
using NUnit.Framework;
namespace DotnetIntern2021Test.Linq.Bai2
{
    class TestExercise11
    {
        private readonly Exercise11 exercise11 = new();
        [Test]
        public void TestEx11()
        {
            var data = new List<int>
            {
                25, 12, 16, 9, 49, 50, 64, 100, 90
            };
            var answer = 263;
            Assert.AreEqual(exercise11.SumOfPerfectSquares(data), answer);
        }
    }
}
