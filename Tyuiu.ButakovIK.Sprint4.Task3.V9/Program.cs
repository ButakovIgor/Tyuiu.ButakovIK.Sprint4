using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.ButakovIK.Sprint4.Task3.V9.Lib;

namespace Tyuiu.ButakovIK.Sprint4.Task3.V9
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();


            Console.Title = "Спринт #4 | Выполнил: Бутаков И.К. | АСОиУБ-23-1";

            Console.WriteLine("****************************************************************************************");
            Console.WriteLine("* Спринт #4                                                                            *");
            Console.WriteLine("* Тема: Одномерные массивы. (генератор случайных чисел)                                *");
            Console.WriteLine("* Таск #3                                                                              *");
            Console.WriteLine("* Вариaнт #9                                                                           *");
            Console.WriteLine("* Выполнил: Бутаков Игорь Константинович | АСОиУБ-23-1                                 *");
  
            int[,] mtrx =  { { 9, 6, 4, 5, 3 },
                                          { 7, 4, 7, 5, 3 },
                                          { 8, 5, 9, 9, 3 },
                                          { 7, 8, 7, 9, 3 },
                                          { 3, 7, 3, 7, 7 } };

            int rows = mtrx.GetUpperBound(0) + 1;
            int columns = mtrx.Length / rows;

            Console.WriteLine("****************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                             *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный статическими        *");
            Console.WriteLine("* значениями в диапазоне от 3 до 9. Найдите сумму элементов во втором столбце массива. *");
            Console.WriteLine("Массив: ");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{mtrx[i, j]} \t ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("****************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                     *");
            Console.WriteLine("****************************************************************************************");

            int res = ds.Calculate(mtrx);
            Console.WriteLine("Сумма второго столбца = " + res);
            Console.ReadKey();
        }
    }
}
