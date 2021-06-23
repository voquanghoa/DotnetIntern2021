using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DotnetIntern2021.Linq.Bai1;
using NUnit.Framework;
namespace DotnetIntern2021Test.Linq.Bai1
{
    class TestExercise3
    {
        private readonly Exercise3 exercise3 = new();
        [Test]
        public void TestEx3()
        {
            var className = "Class A";
            var answer = new[] { "John Leo", "Black Pink", "Bo Gum", "Min Ho", "Xin Chao", "OK OK"};
            Assert.AreEqual(exercise3.FindStudentByClass(className), answer);
        }
    }
}
