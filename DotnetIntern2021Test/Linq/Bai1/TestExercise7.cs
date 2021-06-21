using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using DotnetIntern2021.Linq.Bai1;
namespace DotnetIntern2021Test.Linq.Bai1
{
    class TestExercise7
    {
        private readonly Exercise7 exercise7 = new();
        [Test]
        public void Test()
        {
            var answer = new List<double>
            {
                9.0, 9.5, 8.0, 10.0, 7.0, 6.0, 4.0
            };
            Assert.AreEqual(exercise7.FindAllScores(), answer);
        }
    }
}
