using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint4;

//Вариант 12
//Дан одномерный целочисленный массив на 10 элементов заполненный статическими значениями в диапазоне от 0 до 9 подсчитать произведение
//четных элементов массива.  {4 ,6 ,2 ,8 ,4 ,5 ,6 ,9 ,8 ,7}

namespace Tyuiu.ButakovIK.Sprint4.Task0.V12.Lib
{
    public class DataService : ISprint4Task0V12
    {
        public int GetMultEvenArrEl(int[] array)
        {
            int res = 0;

            for (int i = 0; i <= array.Length - 1; i++)
            {
                if (array[i] % 2 == 0)
                {
                    res += array[i];
                }
            }
            return res;
        }
    }
}
