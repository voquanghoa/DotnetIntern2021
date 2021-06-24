using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DotnetIntern2021.Linq.Bai2;
using NUnit.Framework;
namespace DotnetIntern2021Test.Linq.Bai2
{
    class TestExercise2
    {
        private readonly Exercise2 exercise2 = new();
        [Test]
        public void TestEx01()
        {
            var data = new List<int>
            {
                1, 2, 3, 4, 5, 6, 7, 7, 8, 8, 8, 9
            };
            var answer = new List<int>()
            {
                9, 8, 7
            };
            Assert.AreEqual(exercise2.ThreeHighestValues(data), answer);
        }
    }
}
