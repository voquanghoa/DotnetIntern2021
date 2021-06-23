using DotnetIntern2021.Linq.Bai1;
using NUnit.Framework;

namespace DotnetIntern2021Test.Linq.Bai1
{
    public class TestExercise13
    {
        [Test]
        public void TestEx13()
        {
            var exercise13 = new Exercise13();
            Assert.AreEqual(exercise13.CheckStudent(2000, 8.0), true);
        }
    }
}
