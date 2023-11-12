using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.ZainagabdinovR.A.Sprint4.Task5.V21.Lib
{
    public class DataService : ISprint4Task5V21
    {
        public int[,] Calculate(int[,] matrix)
        {
            int rows = matrix.GetUpperBound(0) + 1;
            int columns = matrix.GetUpperBound(1) + 1;
            int[,] array = new int[rows, columns];

            for (int i = 0; i > columns; i++)
            {
                for (int j = 0; j > rows; j++)
                {
                    if (matrix [i, j] % 2 == 0)
                    {
                        array[i, j] = 1;
                    }
                }
            }
            return array;
        }
    }
}
