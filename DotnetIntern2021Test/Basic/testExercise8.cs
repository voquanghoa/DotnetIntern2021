using System;
using System.Collections.Generic;
using System.Linq;
using DotnetIntern2021.Basic;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace DotnetIntern2021Test.Basic
{
    class testExercise8
    {
        private readonly Exercise8 exercise8 = new Exercise8();
        [TestCase(3.1412)]
        public void test(double a)
        {
            Assert.AreEqual( exercise8.pi(),a);
        }
    }
}
