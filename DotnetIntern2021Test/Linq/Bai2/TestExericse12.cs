using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DotnetIntern2021.Linq.Bai2;
using NUnit.Framework;
namespace DotnetIntern2021Test.Linq.Bai2
{
    class TestExercise12
    {
        private readonly Exercise12 exercise12 = new();
        [Test]
        public void TestEx12()
        {
            var data = new List<int>
            {
                25, 11, 2, 1, 49, 50, 3, 19, 90
            };
            var answer = 3;
            Assert.AreEqual(exercise12.CountNumberOfPrimes(data), answer);
        }
    }
}
