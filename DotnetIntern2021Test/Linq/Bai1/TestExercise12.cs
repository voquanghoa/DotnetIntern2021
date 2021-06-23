using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using DotnetIntern2021.Linq.Bai1;

namespace DotnetIntern2021Test.Linq.Bai1
{
    class TestExercise12
    {
        private readonly Exercise12 exercise12 = new();
        [TestCase("Class A")]
        [TestCase("Class B")]
        public void TestEx12(string className)
        {
            Assert.AreEqual(exercise12.RandomFiveStudentByClass(className), 5);
        }
    }
}
