using DotnetIntern2021.Basic;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetIntern2021Test
{
    public class testExercise3
    {
        private readonly Exercise3 exercise3 = new();

        [TestCase(10,"2*5")]
        [TestCase(9, "3*3")]
        [TestCase(600, "2*2*2*3*5*5")]
        public void TestExercise3(int a, string expected)
        {
            Assert.AreEqual(exercise3.prime(a), expected);
        }
    }
}
