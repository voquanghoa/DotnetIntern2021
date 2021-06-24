using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DotnetIntern2021.Linq.Bai2;
using NUnit.Framework;
namespace DotnetIntern2021Test.Linq.Bai2
{
    class TestExercise9
    {
        private readonly Exercise9 exercise9 = new();
        [Test]
        public void TestEx9()
        {
            var data = new List<int>
            {
                113, 1122, 112233, 16,
                51, 1, 20, 203
            };
            var answer = 1158;
            Assert.AreEqual(exercise9.SumEven(data), answer);
        }
    }
}
