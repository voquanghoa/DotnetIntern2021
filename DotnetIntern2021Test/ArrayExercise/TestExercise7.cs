using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DotnetIntern2021.ArrayExercise;
using NUnit.Framework;
namespace DotnetIntern2021Test.ArrayExercise
{
    class TestExercise7
    {
        private readonly Exercise7 exercise7 = new();

        public void Test()
        {
            var a = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            var arrayList = new List<int[]>
            {
                new int[] { 1,2,3 },
                new int[] { 4,5,6 },
                new int[] { 7 }
            };
            Assert.AreEqual(exercise7.SubArray(a, 3),arrayList);
        }
    }
}
