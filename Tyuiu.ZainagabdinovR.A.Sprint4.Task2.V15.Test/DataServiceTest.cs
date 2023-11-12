using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ZainagabdinovR.A.Sprint4.Task2.V15.Lib;

namespace Tyuiu.ZainagabdinovR.A.Sprint4.Task2.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Valid()
        {
            DataService ds = new DataService();

            int[] numsArray = { 14, 6, 8, 9, 17, 5, 3, 0, 1, 12, 13 };

            int res = ds.Calculate(numsArray);
            int wait = 2;

            Assert.AreEqual(wait, res);
        }
    }
}
