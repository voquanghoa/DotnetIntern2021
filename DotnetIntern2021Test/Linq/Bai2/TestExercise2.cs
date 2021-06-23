using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DotnetIntern2021.Linq.Bai2;
using NUnit.Framework;
namespace DotnetIntern2021Test.Linq.Bai2
{
    class TestExercise2
    {
        private readonly Exercise2 exercise2 = new();
        [Test]
        public void TestEx01()
        {
            var answer = new List<int>()
            {
                -3, -2, -1
            };
            Assert.AreEqual(exercise2.ThreeHighestIndexNumbers(), answer);
        }
    }
}
