using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using DotnetIntern2021.Linq.Bai2;

namespace DotnetIntern2021Test.Linq.Bai2
{
    class TestExercise4
    {
        private readonly Exercise4 exercise4 = new();
        [Test]
        public void TestEx4()
        {
            var input = new List<int>
            {
                11, 12, 43, 90, 51, 46, 78, -75, -63, -59, -47, -34, -28, -14
            };
            var answer = new List<int>
            {
                90, 11, 51, 12, 43, -63, -34, -14, -75, 46, -47, 78, -28, -59
            };
            
            Assert.AreEqual(exercise4.OrderByLastDigit(input), answer);
        }
    }
}
