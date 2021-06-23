using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DotnetIntern2021.Linq.Bai1;
using NUnit.Framework;

namespace DotnetIntern2021Test.Linq.Bai1
{
    class TestExercise10
    {
        private readonly Exercise10 exercise10 = new();
        [Test]
        public void Test()
        {
            var answer = new List<int[]>()
            {
                new[] { 6, 3 },
                new[] { 6, 2 }
            };
            Assert.AreEqual(exercise10.CountScoreHigherThanEight(), answer);
        }
    }
}