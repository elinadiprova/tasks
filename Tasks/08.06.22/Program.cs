using System;

namespace _08._06._22
{
    class Program
    {
        static void Main(string[] args)
        {
            //One();
            //Three();
            Four();
        }

        #region One
        //Найдите сумму отрицательных элементов
        static void One()
        {
            int[] arrat = new int[10];
            int sum = 0;
            Random rnd = new Random();
            for(int i = 0; i< arrat.Length; i++)
            {
                arrat[i] = rnd.Next(-1, 5);
                Console.WriteLine(arrat[i]);
            }
            for(int i = 0; i<arrat.Length; i++)
            {
                if (arrat[i] < 0)
                {
                    sum += arrat[i];
                }
            }
            Console.WriteLine($"sum {sum}");

        }
        #endregion

        #region Two
        //Найти подмножество данного множества чисел такое, что сумма его элементов равна заданному числу.
        static void Two()
        {
             
        }
        #endregion

        #region Three
        //Сортировка выбором
        static void Three()
        {
            int[] array = new int[10];
            Random rnd = new Random();
            int tmp = 0;
            int min = 0;
            for(int i =0; i < array.Length; i++)
            {
                array[i] = rnd.Next(-5, 5);
                Console.WriteLine(array[i]);
            }
            for(int i = 0; i<array.Length; i++)
            {
                min = i;
                for(int j = i +1; j<array.Length; j++)
                {
                    if (array[j] < array[min])
                    {
                        min = j;
                    }
                    
                }
                tmp = array[min];
                array[min] = array[i];
                array[i] = tmp;
            }
            Console.WriteLine("========");
            for(int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
        #endregion

        #region Four
        //Домашнее задание
        static void Four()
        {
            int size = int.Parse(Console.ReadLine());
            string[] numbers = Console.ReadLine().Split(' ');
            int[] array = new int[size];
            int min = 0;
            int max = 0;
            int minIndex = 0;
            int maxIndex = 0;
            int sum = 0;
            int mul = 1;
            for(int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(numbers[i]);
            }
            min = array[0];
            max = array[0];
            for(int i = 0; i < array.Length; i++)
            {
                if (min > array[i])
                {
                    min = array[i];
                    minIndex = i;
                    
                }
                if(max < array[i])
                {
                    max = array[i];
                    maxIndex = i;
                }
                if (array[i] > 0)
                {
                    sum += array[i];
                }
            }

            if(minIndex < maxIndex)
            {
                for (int i = minIndex + 1; i < maxIndex; i++)
                {
                    mul *= array[i];
                }
            }
            else
            {
                for (int i = maxIndex + 1; i < minIndex; i++)
                {
                    mul *= array[i];
                }
            }
            Console.WriteLine($" index {minIndex} {maxIndex}");


            Console.WriteLine($"{sum} {mul}");
        }
        #endregion
    }
}
