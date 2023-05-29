using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace lab4odnommassiv
{
    //Сформировать массив чисел, записанных в порядке возрастания, составленный из нечётных
    //элементов заданного одномерного массива.
    namespace Array
    {
        class Program
        {
            static void Main(string[] args)
            {
                int[] arr = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 23, 29, 32, 47, 59, 66, 71}; // заданный массив
                int count = 0;

                // подсчет количества нечетных элементов в заданном массиве
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] % 2 != 0)
                    {
                        count++;
                    }
                }

                int[] oddArr = new int[count]; // новый массив для нечетных элементов

                // заполнение нового массива нечетными элементами из заданного массива
                int j = 0;
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] % 2 != 0)
                    {
                        oddArr[j] = arr[i];
                        j++;
                    }
                }

                // вывод нового массива на консоль
                Console.WriteLine("Новый массив нечётных чисел:");
                for (int i = 0; i < oddArr.Length; i++)
                {
                    Console.Write(oddArr[i] + " ");
                }
            }
        }
    }
}

