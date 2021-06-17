using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DotnetIntern2021.Strings;
using NUnit.Framework;
namespace DotnetIntern2021Test.Strings
{
    class TestExercise9
    {
        private readonly Exercise9 exercise9 = new();
        [TestCase("8938505974194",true)]
        public void Test(string s, bool expected)
        {
            Assert.AreEqual(exercise9.BarcodeEAN(s), expected);
        }
    }
}
