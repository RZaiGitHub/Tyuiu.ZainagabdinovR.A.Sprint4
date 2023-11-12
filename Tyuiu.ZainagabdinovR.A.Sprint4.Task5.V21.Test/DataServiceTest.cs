using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ZainagabdinovR.A.Sprint4.Task5.V21.Lib;

namespace Tyuiu.ZainagabdinovR.A.Sprint4.Task5.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();

            int[,] matrix = new int[5, 5] {  { 3, 7, -5, 1, -4 },
                                             { -2, 4, 8, -1, -6 },
                                             { 5, -2, -2, 4, 2 },
                                             { -1, 5, -9, -5, 1 },
                                             { 1, 8, -3, 5, -4 } };

            int[,] res = ds.Calculate(matrix);

            int[,] matrixWait = {  { 1, 1, -5, 1, 1 },
                                   { -2, 1, 1, -1, -6 },
                                   { 1, -2, -2, 1, 1 },
                                   { -1, 1, -9, -5, 1 },
                                   { 1, 1, -3, 1, -4 } };

            CollectionAssert.AreEqual(matrixWait, res);
        }
    }
}
