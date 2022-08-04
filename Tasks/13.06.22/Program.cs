using System;
using System.Collections.Generic;
using System.Linq;

namespace _13._06._22
{
    class Program
    {
        static void Main(string[] args)
        {
            //Random rnd = new Random();
            //int[] array = new int[10];

            //for (int i = 0; i<array.Length; i++)
            //{
            //    array[i] = rnd.Next(1, 15);
            //}

            //SortSelection(array);

            SortTime();
        }
        #region Sort
        static void SortSelection(int[] a)
        {
            int N = a.Length;//длина массива 
            int min = 0, imin = 0, i;
            for (i = 0; i < N - 1; i++)
            {
                min = a[i]; imin = i;
                
                for (int j = i + 1; j < N; j++)// в этом цикле ищем минимальный элемент
                    if (a[j] < min)
                    {
                        min = a[j]; imin = j;
                    }
                if (i != imin)
                {
                    // добавление нового элемента в отсортированную часть
                    a[imin] = a[i];
                    a[i] = min;
                }
            }
            for (int k = 0; k < N; k++)
            {
                Console.WriteLine(a[k]);
            }
        }
        #endregion

        #region SortTime
        //Требуется выполнить сортировку временных моментов, заданных в часах, минутах и секундах.
        static void SortTime()
        {
            int size = int.Parse(Console.ReadLine());
            int[,] array = new int[size,4];//почему 4? В 4 будет результат в секундах

            for(int i = 0; i< size; i++)//строка
            {
                var res = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                for (int j = 0; j <3; j++)//столбец
                {
                    array[i, j] = res[j];
                }
                for (int j = 0; j < 3; j++)//столбец
                {
                    if(j == 0)//час
                    {
                        array[i, 3] += array[i, j] * 3600;
                    }
                    if (j == 1)//minute
                    {
                        array[i, 3] += array[i, j] * 60;
                    }
                    if (j == 2)//seconds
                    {
                        array[i, 3] += array[i, j];
                    }
                }
            }
            List<int> result = new List<int>();

            for (int i = 0; i < size; i++)
            {
                result.Add(array[i, 3]);
            }

            result.Sort();
            
            for(int i = 0; i<size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (array[j, 3] == result[i])
                    {
                        Console.WriteLine(array[j, 0] + " " + array[j, 1] + " " + array[j, 2]);
                        break;
                    }
                }
                
            }

        }
        #endregion
    }
}
