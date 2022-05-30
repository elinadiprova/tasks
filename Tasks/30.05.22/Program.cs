using System;
using System.Collections.Generic;
using System.Linq;

namespace _30._05._22
{
    class Program
    {
        static void Main(string[] args)
        {
            //First();
            //Second();
            //Third();
            //FourthArray();
            //FourthLINQ();
            //FiveWithArray();
            //FiveWithLINQ();
            //SixWithArray();
            //SixWithLinq();
            //Seven();
            //Eigth();
            //Nine();
            //Ten();
            //Eleven();
            Twelve();
        }


        #region First
        //Вывести элементы числового массива, которые больше, чем элементы, стоящие перед ними.
        static void First()
        {
            int[] array = new int[] { 3, 9, 8, 4, 5, 1 };

            for (int i = 1; i < array.Length - 1; i++)
            {
                if (array[i] > array[i + 1])
                {
                    Console.WriteLine(array[i]);
                }
            }
        }
        #endregion

        #region Second
        //Все элементы массива поделить на значение наибольшего элемента этого массива.
        static void Second()
        {
            int[] array2 = new int[] { 327, 381, 891, 918, 212, 848, 770, 363, 416, 736 };
            int max = 0;
            for (int i = 0; i < array2.Length - 1; i++)
            {
                if (max < array2[i])
                {
                    max = array2[i];
                }
            }
            Console.WriteLine(max);

            for (int i = 0; i < array2.Length - 1; i++)
            {
                Console.WriteLine(array2[i] % max);
            }
        }

        #endregion

        #region Third
        //Все элементы массива поделить на значение наименьшего элемента этого массива.

        static void Third()
        {
            int[] array3 = new int[] { 327, 381, 891, 918, 212, 848, 770, 363, 416, 736 };
            int min = array3[0];
            for (int i = 0; i < array3.Length; i++)
            {
                if (array3[i] <= min)
                {
                    min = array3[i];
                }
            }
            Console.WriteLine(min);
        }
        #endregion

        #region Fourth  with array 
        //Первый положительный элемент массива
        //Задача
        //Найти номер и значение первого положительного элемента массива
        static void FourthArray()
        {
            int[] array = new int[] { -327, -381, -891, -918, -212, -848, -770, 363, 416, 736 };
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                {
                    Console.WriteLine(array[i]);
                    break;
                }
            }
        }

        #endregion

        #region Fourth  with LINQ 
        //Первый положительный элемент списка
        //Задача
        //Найти номер и значение первого положительного элемента списка
        static void FourthLINQ()
        {
            int[] array = new int[] { -327, -381, -891, -918, -212, -848, -770, 363, 416, 736 };

            List<int> list = new List<int>();
            list.AddRange(array);
            var check = list.FirstOrDefault(w => w > 0);
            Console.WriteLine(check);
            //list.ForEach(x => Console.WriteLine(x));
        }

        #endregion

        #region Five with Array
        //Задача
        //Дан массив, содержащий положительные и отрицательные числа.Заменить все элементы массива на противоположные по знаку.
        //Например, задан массив [1, -5, 0, 3, -4]. После преобразования должно получиться [-1, 5, 0, -3, 4].
        static void FiveWithArray() 
        {
            int[] array = new int[] { -327, -381, -891, -918, -212, -848, -770, 363, 416, 736 };
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i] * (-1));
            }
        }
        #endregion

        #region Five with LINQ
        //Задача
        //Дан массив, содержащий положительные и отрицательные числа.Заменить все элементы массива на противоположные по знаку.
        //Например, задан массив [1, -5, 0, 3, -4]. После преобразования должно получиться [-1, 5, 0, -3, 4].
        static void FiveWithLINQ()
        {
            int[] array = new int[] { -327, -381, -891, -918, -212, -848, -770, 363, 416, 736 };
            List<int> list = new List<int>();
            list.AddRange(array);

            list.ForEach(w => Console.WriteLine(w * -1));
        }   
        #endregion

        #region Six wih Array
        //Задача
        //В одномерном массиве найти минимальный и максимальный элементы. Вычислить их разность.
        //Например, дан массив[3, 5, 9, 4, 2, 6]. Максимальным числом является 9, минимальным является 2. Разность составляет 9-2=7.
        static void SixWithArray()
        {
            int[] array = new int[] { -327, -381, -891, 918, -212, -848, -770, 363, 416, 736 };
            int min = array[0];
            int max = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                }
                if (array[i] > max)
                {
                    max = array[i];
                }
            }
            Console.WriteLine($"{max} - {min} = {max - min}");
        }
        #endregion

        #region Six with Linq
        //В одномерном массиве найти минимальный и максимальный элементы. Вычислить их разность.
        //Например, дан массив[3, 5, 9, 4, 2, 6]. Максимальным числом является 9, минимальным является 2. Разность составляет 9-2=7.
        static void SixWithLinq()
        {
            int[] array = new int[] { -327, -381, -891, 918, -212, -848, -770, 363, 416, 736 };
            List<int> list = new List<int>();
            list.AddRange(array);
            Console.WriteLine($"{list.Max()} - {list.Min()} = {list.Max() - list.Min() }");
        }

        #endregion

        #region Seven with Array
        //В массиве найти минимальный и максимальный элементы, поменять их местами.
        static void Seven()
        {
            int[] array = new int[] { -327, -381, -891, 918, -212, -848, -770, 363, 416, 736 };
            int max = 0;
            int min = 0;
            for (int i=0; i < array.Length; i++){
                if(array[i] < array[min])
                {
                    min =i;
                }
                if (array[i] > array[max])
                {
                    max = i;
                }
            }

            for (int i=0; i<array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }
            Console.Write($"\n min {min}");
            Console.Write($" max {max}\n");
            int tmp = array[min];
            array[min] = array[max];
            array[max] = tmp;
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }
        }

        #endregion

        #region Eight
        //Дан одномерный массив. Найти среднее арифметическое его элементов. Вывести на экран только те элементы массива,
        //которые больше найденного среднего арифметического.
        static void Eigth()
        {
            int[] array = new int[] { 327, 381, 891, 918, 212, 848, 770, 363, 416, 736 };
            long sum = 0;
            for(int i = 0; i<array.Length; i++)
            {
                sum += array[i];
            }
            for(int i = 0; i<array.Length; i++)
            {
                if (array[i] > (sum / array.Length))
                {
                    Console.Write($"{array[i]} "); ;
                }
            }
            Console.WriteLine($"Sum = {sum}; Average = {sum/array.Length}");
        }
        #endregion

        #region Nine
        //Найти сумму положительных элементов массива.
        static void Nine()
        {
            int[] array = new int[] { -327, -381, -891, 918, -212, -848, -770, 363, 416, 736 };
            long sum = 0;
            for(int i = 0; i<array.Length; i++)
            {
                if (array[i] > 0)
                {
                    sum += array[i];
                }
            }
            Console.WriteLine($"Sum = {sum}");
        }

        #endregion

        #region Ten
        //В одномерном массиве найти количество положительных элементов.
        static void Ten()
        {
            int[] array = new int[] { -327, -381, -891, 918, -212, -848, -770, 363, 416, 736 };
            int count = 0; 
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                {
                    count++;
                }
            }
            Console.WriteLine($"Count of positive numbers = {count}");
        }
        #endregion

        #region Eleven
        //В массиве определить индексы элементов, значение которых не меньше заданного минимума и не больше заданного максимума.
        static void Eleven()
        {
            int[] array = new int[] { -327, -381, -891, 918, -212, -848, -770, 363, 416, 736 };
            int min = -500;
            int max = 500;
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }
            Console.WriteLine($"\n min = {min} ; max = {max} \n");
            for (int i = 0; i<array.Length; i++)
            {
                if(array[i] >= min && array[i] <= max)
                {
                    Console.Write($"\n {array[i]}");
                }
            }

        }
        #endregion

        #region Twelve
        //В однородном массиве, состоящем из N вещественных элементов, найти максимальный по модулю элемент массива.
        static void Twelve()
        {
            double[] array = new double[] { 0.18, 0.02, 0.04, 0.06, -0.03, 0.34, -0.3, -0.35, 0.12, -0.12 };
            double max = 0.0;
            for(int i = 0; i<array.Length; i++)
            {
                if(Math.Abs(array[i]) > Math.Abs(max))
                {
                    max = array[i];
                }
            }
            Console.WriteLine(max);
        }
        #endregion


    }
}
