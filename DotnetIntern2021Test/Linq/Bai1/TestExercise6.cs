using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DotnetIntern2021.Linq.Bai1;
using NUnit.Framework;

namespace DotnetIntern2021Test.Linq.Bai1
{
    class TestExercise6
    {
        private readonly Exercise6 exercise6 = new();
        public void Test()
        {
            var answer = new List<string>
            {
                "Black Pink", "Hyun Bin", "Bo Gum"
            };
            Assert.AreEqual(exercise6.FindStudentContainsXname("B"), answer);
        }
    }
}
