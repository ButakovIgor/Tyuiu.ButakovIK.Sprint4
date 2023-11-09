using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.ButakovIK.Sprint4.Task6.V12.Lib;

namespace Tyuiu.ButakovIK.Sprint4.Task6.V12
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #4 | Выполнил: Бутаков И.К. | АСОиУБ-23-1";

            Console.WriteLine("****************************************************************************************");
            Console.WriteLine("* Спринт #4                                                                            *");
            Console.WriteLine("* Тема: Класс Array                                                                    *");
            Console.WriteLine("* Таск #6                                                                              *");
            Console.WriteLine("* Вариaнт #12                                                                          *");
            Console.WriteLine("* Выполнил: Бутаков Игорь Константинович | АСОиУБ-23-1                                 *");
            Console.WriteLine("****************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                             *");
            Console.WriteLine("* Дан строковый массив данных, используя класс Array, выведите элементы массива, длина *");
            Console.WriteLine("* которых равна 7 символам.                                                            *");
            Console.WriteLine("****************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                     *");
            Console.WriteLine("****************************************************************************************");

            string[] array = { "Россия", "Украина", "Беларусь", "Казахстан", "Молдова", "Латвия", "Эстония" };
            Console.Write("Маcсив:'Компьютер', 'Телефон', 'Планшет','Принтер', 'Сканер', 'Монитор', 'Клавиатура'");

            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string[] res = ds.Calculate(array);
            foreach (string word in res)
            {
                Console.Write(word + "\t");
            }
            Console.ReadKey();
        }
    }
}
