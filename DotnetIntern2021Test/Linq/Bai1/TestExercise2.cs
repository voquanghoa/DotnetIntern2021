using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DotnetIntern2021.Linq.Bai1;
using NUnit.Framework;
namespace DotnetIntern2021Test.Linq.Bai1
{
    class TestExercise2
    {
        private readonly Exercise2 exercise2 = new();
        [Test]
        public void TestEx2()
        {
            int year = 2000;
            var answer = new[] { 1, 2 };
            Assert.AreEqual(exercise2.FindStudentByBirthdayYear(year).Select(x=>x.Id).ToArray(), answer);
        }
    }
}
