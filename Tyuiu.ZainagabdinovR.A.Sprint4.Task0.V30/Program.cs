using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.ZainagabdinovR.A.Sprint4.Task0.V30.Lib;

namespace Tyuiu.ZainagabdinovR.A.Sprint4.Task0.V30
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнил: Зайнагабдинов Р. А. | ИСТНб-23-1";
            //Длина строки 75 символов
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Одномерные массивы (статический ввод)                             *");
            Console.WriteLine("* Задание #4.0                                                            *");
            Console.WriteLine("* Вариант #30                                                             *");
            Console.WriteLine("* Выполнил: Зайнагабдинов Руслан Айратович | ИСТНб-23-1                   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 10 элементов заполненный         *");
            Console.WriteLine("* статическими значениями в диапазоне от 0 до 9 подсчитать                *");
            Console.WriteLine("* сумму четных элементов массива.                                         *");
            Console.WriteLine("* {9, 8, 4, 6, 9, 4, 3, 6, 1, 2}                                          *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int[] array = { 9, 8, 4, 6, 9, 4, 3, 6, 1, 2 };

            Console.WriteLine("Исходный массив:");
            for (int i = 0; 1 <= array.Length - 1; i++)
            {
                Console.WriteLine(array[i]);
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Результурующий массив:");

            array = ds.GetSumEvenArrEl(array);

            for (int i = 0; i <= array.Length - 1; i++)
            {
                Console.Write(array[i] + "\t");
            }

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
