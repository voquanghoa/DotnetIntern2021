using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using DotnetIntern2021.Linq.Bai1;

namespace DotnetIntern2021Test.Linq.Bai1
{
    class TestExercise14
    {
        private readonly Exercise14 exercise14 = new();
        [Test]
        public void TestEx14()
        {
            var className = "Class A";
            var answer = new List<string>
            {
                "Xin Chao", "Bo Gum", "Min Ho", 
                "John Leo", "OK OK", "Black Pink"
            };
            Assert.AreEqual(exercise14.OrderStudentsByName(className), answer);
        }
    }
}
