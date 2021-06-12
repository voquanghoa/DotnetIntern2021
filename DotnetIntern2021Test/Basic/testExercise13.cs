using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DotnetIntern2021;
using NUnit.Framework;
namespace DotnetIntern2021Test
{
    class testExercise13
    {
        private readonly Exercise13 exercise13 = new();
        [TestCase("128168123", new[] { "1.28.168.123", "12.8.168.123", "12.81.68.123",
        "128.1.68.123", "128.16.8.123", "128.16.81.23", "128.168.1.23", "128.168.12.3"
        })]
        public void test(String a, String[] expected)
        {
            Assert.AreEqual(exercise13.restoreIpAddresses(a), expected);
        }
    }
}
