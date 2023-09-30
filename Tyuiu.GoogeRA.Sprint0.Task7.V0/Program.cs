using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.GoogeRA.Sprint0.Task7.V0.Lib;

namespace Tyuiu.GoogeRA.Sprint0.Task7.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #0| Выполнил :  Гооге Р.A. | ПКТб-23-1";
            Console.WriteLine("*****************************************************************************");
            Console.WriteLine("* Спринт #0                                                                 *");
            Console.WriteLine("* Тема: Создание итогового решения  по спринту                              *");
            Console.WriteLine("* Задние #7                                                                 *");
            Console.WriteLine("* Вариант #0                                                                *");
            Console.WriteLine("* Выполнил :  Гооге Роберт Aлексндрович | ПКТб-23-1                         *");
            Console.WriteLine("*****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                  *");
            Console.WriteLine("* Написать консольную программу на С#, которая суммирует значение двух      *");
            Console.WriteLine("* одинаковых массивов по длинне.                                            *");
            Console.WriteLine("*                                                                           *");
            Console.WriteLine("*****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                          *");
            Console.WriteLine("*****************************************************************************");

            int[] arrayNums1 = new int[] { 1, 2, 3, 4, 5 };

            Console.WriteLine("Значение элементов массива №1");
            for (int i = 0; i < arrayNums1.Length; i++)
            {
                Console.Write(arrayNums1[i] + ", ");
            }

            Console.WriteLine();

            int[] arrayNums2 = new int[] { 1, 2, 3, 4, 5 };
            Console.WriteLine("Значение элементов массива №2");
            for (int i = 0; i < arrayNums2.Length; i++)
            {
                Console.Write(arrayNums1[i] + ", ");
            }
            Console.WriteLine();
            Console.WriteLine("*****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                *");
            Console.WriteLine("*****************************************************************************");
            if (arrayNums1.Length == arrayNums2.Length)
            {
                int[] resultArrey = DataService.AdditionArrays(arrayNums1, arrayNums2);
                Console.WriteLine("Сумма элементов массива ровна:");
                for (int i = 0; i < resultArrey.Length;  i++ )
                {
                    Console.Write(resultArrey[i] + ", ");
                }
            }
            else
            {
                Console.WriteLine(" Ошибка! Исходные массивы имеют разное значение");
            }
            Console.ReadKey();
        }

    }
}
