﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ZainagagbdinovR.A.Sprint4.Task6.V17.Lib;

namespace Tyuiu.ZainagagbdinovR.A.Sprint4.Task6.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            var program = new string[] { "Python", "JavaScript", "Java", "C#", "Swift", "Kotlin", "Ruby" };
            int res = ds.Calculate(program);
            int wait = 2;
            Assert.AreEqual(wait, res);
        }
    }
}
