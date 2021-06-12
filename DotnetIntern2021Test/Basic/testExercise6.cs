using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DotnetIntern2021.Basic;
using NUnit.Framework;

namespace DotnetIntern2021Test.Basic
{
    class testExercise6
    {
        private readonly Exercise6 exercise6 = new();
         [TestCase(2,35)]
         [TestCase(3, 143)]
        public void TestExercise2(int a, int expected)
         {
             Assert.AreEqual(exercise6.sum(a), expected);
         }
    }
}
