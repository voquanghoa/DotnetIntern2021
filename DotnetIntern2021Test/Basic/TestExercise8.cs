
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using DotnetIntern2021.Basic;
namespace DotnetIntern2021Test.Basic
{
    class TestExercise8
    {
        private readonly Exercise8 exercise8 = new Exercise8();
        [TestCase(3.1415826535897806,Exercise8.epsilon)]
        public void Test(double a, double epsilon)
        {
            Assert.AreEqual(exercise8.Pi(epsilon), a);
        }
    }
}
