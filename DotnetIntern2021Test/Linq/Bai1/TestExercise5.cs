using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DotnetIntern2021.Linq.Bai1;
using NUnit.Framework;

namespace DotnetIntern2021Test.Linq.Bai1
{
    class TestExercise5
    {
        private readonly Exercise5 exercise5 = new();
        [Test]
        public void Test()
        {
            var answer = new List<string>() { "John Leo", "Hyun Bin" };
            Assert.AreEqual(exercise5.MaxScoreGroupByClass(), answer);
        }
    }
}
