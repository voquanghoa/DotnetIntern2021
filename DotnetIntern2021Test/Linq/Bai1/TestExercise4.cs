using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DotnetIntern2021.Linq.Bai1;
using NUnit.Framework;
namespace DotnetIntern2021Test.Linq.Bai1
{
    class TestExercise4
    {
        private readonly Exercise4 exercise4 = new();
        [Test]
        public void TestEx4()
        {
            string className = "Class A";
            var answer = 7.833333333333333;
            Assert.AreEqual(exercise4.AverageScoreByClassname(className),answer);
        }
    }
}
