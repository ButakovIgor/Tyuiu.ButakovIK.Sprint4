using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.ButakovIK.Sprint4.Task0.V12.Lib;

//Вариант 12
//Дан одномерный целочисленный массив на 10 элементов заполненный статическими значениями в диапазоне от 0 до 9 подсчитать произведение
//четных элементов массива.  {4 ,6 ,2 ,8 ,4 ,5 ,6 ,9 ,8 ,7}


namespace Tyuiu.ButakovIK.Sprint4.Task0.V12
{
    class Program
    {
        static void Main(string[] args)
        {

            DataService ds = new DataService();
            Console.Title = "Спринт #4 | Выполнил: Бутаков И.К. | АСОиУБ-23-1";

            Console.WriteLine("**********************************************************************************");
            Console.WriteLine("* Спринт #4                                                                      *");
            Console.WriteLine("* Тема: Одномерные массивы (статический ввод)                                    *");
            Console.WriteLine("* Таск #0                                                                        *");
            Console.WriteLine("* Вариaнт #12                                                                    *");
            Console.WriteLine("* Выполнил: Бутаков Игорь Константинович | АСОиУБ-23-1                           *");
            Console.WriteLine("**********************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                       *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 10 элементов заполненный статическими   *");
            Console.WriteLine("* значениями в диапазоне от 0 до 9 подсчитать произведение четных элементов      *");
            Console.WriteLine("* массива.  {4 ,6 ,2 ,8 ,4 ,5 ,6 ,9 ,8 ,7}                                       *");
            Console.WriteLine("**********************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                               *");
            Console.WriteLine("**********************************************************************************");

            int[] numsArray = { 4, 6, 2, 8, 4, 5, 6, 9, 8, 7 };
            Console.WriteLine("Массив: ");
            for (int i = 0; i <= numsArray.Length - 1; i++)
            {
                Console.WriteLine(numsArray[i]);
            }

            Console.WriteLine("**********************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                     *");
            Console.WriteLine("**********************************************************************************");

            int res = ds.GetMultEvenArrEl(numsArray);
            Console.WriteLine("Результат сложения чётных чисел: " + ds.GetMultEvenArrEl(numsArray));
            Console.ReadKey();
        }
    }
}
