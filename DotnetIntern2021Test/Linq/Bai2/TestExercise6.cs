using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DotnetIntern2021.Linq.Bai2;
using NUnit.Framework;
namespace DotnetIntern2021Test.Linq.Bai2
{
    class TestExercise6
    {
        private readonly Exercise6 exercise6 = new();
        [Test]
        public void TestEx6()
        {
            var data = new List<int>
            {
                11, 11, 11, 20, 51, 46, 20, 11, -63, 20, -47, 20, -28, 20
            };
            var answer = new List<int>
            {
                51, 46, -63, -47, -28
            };
            Assert.AreEqual(exercise6.NoneRepeatedNumber(data), answer);
        }
    }
}
