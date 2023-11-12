using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.ZainagabdinovR.A.Sprint4.Task2.V15.Lib
{
    public class DataService : ISprint4Task2V15
    {
        public int Calculate(int[] array)
        {
            int sumArray = 0;

            for (int i = 2; i <= array.Length - 4; i++)
            {
                if (array[i] % 2 == 0)
                {
                    sumArray += array[i];
                }
            }
            return sumArray;
        }
    }
}
