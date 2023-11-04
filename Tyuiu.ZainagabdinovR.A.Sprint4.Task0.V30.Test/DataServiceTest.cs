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

            int[] array = { 9, 8, 4, 6, 9, 4, 3, 6, 1, 2 };

            int res = ds.GetSumEvenArrEl(array);
            int wait = 30;

            Assert.AreEqual(wait, res);
        }
    }
}
