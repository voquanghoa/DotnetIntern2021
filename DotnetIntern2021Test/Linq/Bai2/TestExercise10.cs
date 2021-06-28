using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DotnetIntern2021.Linq.Bai2;
using NUnit.Framework;
namespace DotnetIntern2021Test.Linq.Bai2
{
    class TestExercise10
    {
        private readonly Exercise10 exercise10 = new();
        [Test]
        public void TestEx10()
        {
            var data = new List<int>
            {
                25, 12, 16, 9, 49, 50, 64, 100, 90
            };
            var answer = 100;
            Assert.AreEqual(exercise10.MaxPerfectSquare(data), answer);
        }
    }
}
