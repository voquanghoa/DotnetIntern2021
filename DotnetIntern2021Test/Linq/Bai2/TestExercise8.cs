using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DotnetIntern2021.Linq.Bai2;
using NUnit.Framework;
namespace DotnetIntern2021Test.Linq.Bai2
{
    class TestExercise8
    {
        private readonly Exercise8 exercise8 = new();
        [Test]
        public void TestEx8()
        {
            var data = new List<int>
            {
                113, 1122, 112233, 16,
                51, 1, 20, 203
            };
            var answer = new List<int>
            {
                1, 16, 20, 51,
                113, 203, 1122, 112233
            };
            Assert.AreEqual(exercise8.OrderByNumberOfDigits(data), answer);
        }
    }
}
