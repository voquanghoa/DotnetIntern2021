using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using DotnetIntern2021.Linq.Bai2;

namespace DotnetIntern2021Test.Linq.Bai2
{
    class TestExercise5
    {
        private readonly Exercise5 exercise5 = new();
        [Test]
        public void TestEx05()
        {
            var data = new List<int>
            {
                11, 11, 11, 20, 51, 46, 20, 11, -63, 20, -47, 20, -28, 20
            };
            var answer = 20;
            Assert.AreEqual(exercise5.MostRepeatedNumber(data), answer);
        }
    }
}
