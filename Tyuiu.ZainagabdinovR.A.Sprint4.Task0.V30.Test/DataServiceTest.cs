using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ZainagabdinovR.A.Sprint4.Task0.V30.Lib;

namespace Tyuiu.ZainagabdinovR.A.Sprint4.Task0.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();

            int[] numsArray = { 9, 8, 4, 6, 9, };
            int res = ds.GetSumEvenArrEl(numsArray);
            int[] numsWaitArray = { 4, 3, 6, 1, 2 };
            Assert.AreEqual(numsWaitArray, res);
        }
    }
}
