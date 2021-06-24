using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DotnetIntern2021.Linq.Bai2;
using NUnit.Framework;

namespace DotnetIntern2021Test.Linq.Bai2
{
    class TestExercise3
    {
        private readonly Exercise3 exercise3 = new();
        [TestCase(5)]
        [TestCase(8)]
        public void Test_RandomNumbers(int n)
        {
            var data = new List<int>
            {
                1, 2, 3, 4, 5, 6, 7, -7, -6, -5, -4, -3, -2, -1
            };
            Assert.AreEqual(exercise3.RandomNumbers(data,n).Count, n);
        }
    }
}
