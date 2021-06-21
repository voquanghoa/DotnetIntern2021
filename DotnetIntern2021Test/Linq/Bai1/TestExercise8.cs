using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DotnetIntern2021.Linq.Bai1;
using NUnit.Framework;

namespace DotnetIntern2021Test.Linq.Bai1
{
    class TestExercise8
    {
        private readonly Exercise8 exercise8 = new();
        [Test]
        public void Test()
        {
            var answer = new List<string>
            {
                "Yu Chun", "Mickey"
            };
            Assert.AreEqual(exercise8.ScoreLowerThanFive(), answer);
        }
    }
}
