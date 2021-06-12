﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DotnetIntern2021;
using NUnit.Framework;
namespace DotnetIntern2021Test
{
    public class testExercise14
    {
        private readonly Exercise14 exercise14 = new();
        [TestCase(5,1)]
        [TestCase(13, 2)]
        [TestCase(4, 0)]
        public void test(int a, int expected)
        {
            Assert.AreEqual(exercise14.count(a), expected);
        }
    }
}