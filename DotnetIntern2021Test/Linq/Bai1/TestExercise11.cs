using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using DotnetIntern2021.Linq.Bai1;
namespace DotnetIntern2021Test.Linq.Bai1
{
    class TestExercise11
    {
        private readonly Exercise11 exercise11 = new();
        [Test]
        public void TestEx11()
        {
            Assert.AreEqual(exercise11.FindStudentContainsName(), "Class A");
        }
    }
}
