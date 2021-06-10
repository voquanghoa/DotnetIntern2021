using DotnetIntern2021;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetIntern2021Test
{
    public class testExercise1
    {
        private readonly Exercise1 exercise1 = new();
        
        [TestCase(4,5,20)]
        [TestCase(2, 12, 12)]
        [TestCase(15, 3, 15)]
        public void TestBCNN(int a, int b, int expected)
        {
            Assert.AreEqual(exercise1.BCNN(a, b), expected);
        }

        [TestCase(14, 7, 7)]
        [TestCase(20, 12, 4)]
        [TestCase(21, 5, 1)]
        public void TestUCLN(int a, int b, int expected)
        {
            Assert.AreEqual(exercise1.UCLN(a, b), expected);
        }
    }
}
