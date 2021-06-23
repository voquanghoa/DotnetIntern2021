using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DotnetIntern2021.Linq.Bai2;
using NUnit.Framework;
namespace DotnetIntern2021Test.Linq.Bai2
{
    class TestExercise7
    {
        private readonly Exercise7 exercise7 = new();
        [Test]
        public void TestEx7()
        {
            var data = new List<int>
            {
                11, 11, 11, 20, 51, 46, 20, 11, -63, 20, 51, 20, -28, 20
            };
            var answer = new List<int>
            {
                11, 20, 51
            };
            Assert.AreEqual(exercise7.RepeatedNumbers(data), answer);
        }
    }
}
