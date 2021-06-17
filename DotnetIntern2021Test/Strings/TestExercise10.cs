using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DotnetIntern2021.Strings;
using NUnit.Framework;
namespace DotnetIntern2021Test.Strings
{
    class TestExercise10
    {
        private readonly Exercise10 exercise10 = new();
        [Test]
        public void Test()
        {
            string fullName = "Johnson Baby For Kids";
            var expected = new List<string>(){ "Johnson Baby For", "Kids" };
            Assert.AreEqual(exercise10.SeparateFullName(fullName), expected);
        }
    }
}
