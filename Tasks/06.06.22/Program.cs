using System;
using System.IO;

namespace _06._06._22
{
    class Program
    {
        static void Main()
        {
            //One();
            //Two();
            //Three();
            //Four();
            //Five();
            Eight();
        }

        #region One
        //Линейный массив содержит сведения о количестве осадков, выпавших за каждый из 12 месяцев одного года.
        //Составить программу, определяющую общее количество осадков за этот год, среднемесячное количество осадков,
        //количество засушливых месяцев (когда количество осадков было меньше 30 мм), самый засушливый месяц года.
        static void One()
        {
            int[] array = new int[12];
            Random rnd = new Random();
            int sum = 0;
            int count = 0;
            int min = 0;
            int month = 0;
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(20, 40);
            }
            min = array[0];

            for (int i = 0; i < array.Length; i++)
            {
                if (min > array[i])
                {
                    min = array[i];
                    month = i;
                }
                if (array[i] < 30)
                {
                    count++;
                }
                sum += array[i];
            }

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"{i + 1}) {array[i]}");
            }
            Console.WriteLine($"\n avg = {sum / array.Length}; total = {sum}; count of dry months = {count}; the driest months = {month}");

        }
        #endregion

        #region Two
        //Если в одномерном массиве имеются три подряд идущих одинаковых элемента, то переменной r присвоить значение истина.
        static void Two()
        {
            int[] array = new int[] { 2, 3, 4, 5, 1, 5, 5, 5 };
            bool r = false;
            int count = 1;
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] == array[i + 1])
                {
                    count++;
                }
                if (array[i] != array[i + 1] && count < 3)
                {
                    count = 1;
                }
            }
            if (count >= 3)
            {
                r = true;
            }
            Console.WriteLine(r);
        }
        #endregion

        #region Three
        //Номер дня с начала года.
        //Заданы три числа, которые обозначают число, месяц, год. Найти порядковый номер даты, начиная отсчет с начала года.
        static void Three()
        {
            int[] array = new int[] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };// год невисокосный(его месяцы)
            int number = 10;
            int month = 3;
            int year = 2012;

            int quantity = 0;
            //но при этом не кратны 100, а также те, которые заканчиваются на 00 и делятся нацело на 400.
            if (year % 4 == 0 && year % 100 != 0 || year % 400 == 0)// проверка на високосный год
            {
                array[1]++;
            }
            for (int i = 0; i < month - 1; i++)
            {
                quantity += array[i];
            }
            Console.WriteLine($"{quantity + number}");

        }
        #endregion

        #region Four
        //Найдите сумму элементов массива между двумя первыми нулями. Если двух нулей нет в массиве, то выведите ноль. Решение - переделать
        static void Four()
        {
            int[] array = new int[] { 12, 9, 5, 5, 5, 0, 4 };
            int sum = 0;
            int zero1 = 0;
            int zero2 = 0;
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (zero1 == array[i])
                {
                    zero1 = i;
                    count++;
                }
            }
            for (int i = zero1 + 1; i < array.Length; i++) //от первого найденного нуля до конца цикла
            {
                if (zero2 == array[i])
                {
                    zero2 = i;
                    count++;
                }
            }
            if (count == 2)
            {
                for (int i = zero1 + 1; i < zero2; i++)
                {
                    Console.WriteLine(array[i]);
                    sum += array[i];
                }
                Console.WriteLine(sum);
            }
            else if (count < 2)
            {
                Console.WriteLine("does not contain zeros");
            }
        }
        #endregion

        #region Five
        //Найдите наименьший четный элемент массива. Если такого нет, то выведите первый элемент. Решение
        static void Five()
        {
            int[] array = new int[10];
            int min = 0;
            int n = 0;
            Random rnd = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(1, 10);
                Console.WriteLine(array[i]);
            }
            min = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (min > array[i] && array[i] % 2 == 0)
                {
                    min = array[i];
                    n++;
                    break;
                }
            }
            if (n > 0)
            {
                Console.WriteLine($"min {min}");

            }
            else
            {
                Console.WriteLine($"first element {array[0]}");
            }
        }
        #endregion

        #region Six
        //сложная формулировка,но по факту сложить 2 числа
        static void Six()
        {
            var numbers = Console.ReadLine().Split(' ');
            if (int.Parse(numbers[0]) + int.Parse(numbers[1]) == int.Parse(numbers[2]))
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
        #endregion

        #region Seven
        static void Seven()
        {
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine($"{5}9{9-num}");
        }
        #endregion

        #region Eight
        static void Eight()
        {
            //string numbers = "";
            
            //using (StreamReader sr = new StreamReader("INPUT.TXT"))
            //{
            //    numbers = sr.ReadLine();
            //}

            //Console.WriteLine(numbers);
            //string[] array = new string[] { numbers };
            //string[] a = new string[array.Length / 2];
            //string[] b = new string[array.Length / 2];
            //int p = 0;
            //int c = 0;
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if((i + 1) % 2 != 0)
            //    {
            //        a[p] = array[i];
            //        p++;
            //    }
            //    else
            //    {
            //        b[c] = array[i];
            //        c++;
            //    }
            //}

        }
        #endregion
    }
}
