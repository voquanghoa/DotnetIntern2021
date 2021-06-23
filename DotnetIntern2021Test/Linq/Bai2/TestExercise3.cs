using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DotnetIntern2021.Linq.Bai2;
using NUnit.Framework;

namespace DotnetIntern2021Test.Linq.Bai2
{
    class TestExercise3
    {
        private readonly Exercise3 exercise3 = new();
        [TestCase(5)]
        [TestCase(8)]
        public void TestEx03(int n)
        {
            Assert.AreEqual(exercise3.RandomNumbers(n), n);
        }
    }
}
