using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.ZainagabdinovR.A.Sprint4.Task3.V26.Lib
{
    public class DataService : ISprint4Task3V26
    {
        public int Calculate(int[,] array)
        {
            int rows = array.GetUpperBound(0) + 1;
            int columns = array.GetUpperBound(1) + 1;

            for (int i = 1; i < rows; i++)
            {
                int max = array[i, 0];
                for (int j = 0; j < columns; j++)
                {
                    if (array[i, j] > max) max = array[i, j];
                }
            }
            return rows;
        }
    }
}
