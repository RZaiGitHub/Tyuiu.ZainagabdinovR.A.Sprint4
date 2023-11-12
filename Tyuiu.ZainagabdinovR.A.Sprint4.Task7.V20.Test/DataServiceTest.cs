using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ZainagabdinovR.A.Sprint4.Task7.V20.Lib;

namespace Tyuiu.ZainagabdinovR.A.Sprint4.Task7.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValicCalc()
        {
            int n = 5;
            int m = 3;
            int[,] mtrx = new int[n, m];
            string str = "357951248632587";
            DataService ds = new DataService();
            int res = ds.Calculate(n, m, str);
            int wait = 6;
            Assert.AreEqual(wait, res);
        }
    }
}
