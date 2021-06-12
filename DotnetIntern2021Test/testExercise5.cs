using DotnetIntern2021.Basic;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetIntern2021Test
{
    public class testExercise5
    {
        private readonly Exercise5 exercise5 = new();
        [TestCase(160, new[] { 153 })]
        [TestCase(5000, new[] { 153, 370, 371, 407, 1634 })]
        public void TestExercise4(int a, int[] expected)
        {
            Assert.AreEqual(exercise5.bai5(a), expected);
        }
    }
}
