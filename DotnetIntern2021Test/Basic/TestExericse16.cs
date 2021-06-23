using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DotnetIntern2021.Basic;
using NUnit.Framework;

namespace DotnetIntern2021Test.Basic
{
    class TestExericse16
    {
        private readonly Exercise16 exercise16 = new();
        [TestCase(2,true)]
        [TestCase(3, true)]
        [TestCase(5, true)]
        [TestCase(16, true)]
        [TestCase(10, true)]
        [TestCase(15, true)]
        [TestCase(24, true)]
        [TestCase(7,false)]
        [TestCase(119, false)]
        public void Test(int a, bool expected)
        {
            Assert.AreEqual(exercise16.checkPrime(a),expected);
        }
    }
}
