using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.ZainagabdinovR.A.Sprint4.Task4.V28.Lib
{
    public class DataService : ISprint4Task4V28
    {
        public int Calculate(int[,] matrix)
        {
            int rows = matrix.GetUpperBound(0) + 1;
            int columns = matrix.GetUpperBound(1) + 1;

            int count = 0;

            for (int i = 0; i < columns; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    if (matrix[i, j] % 2 == 0)
                    {
                        count++; 
                    }
                }
            }
            return count;
        }
    }
}
