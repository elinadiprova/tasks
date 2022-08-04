using System;

namespace _21._06._22
{
    class Program
    {
        static void Main(string[] args)
        {
            //BubbleSort();
            //SelectionSort();
            //One();
            SortingByInserts();
        }

        //Bubble sort
        static void BubbleSort()
        {
            int[] array = new int[] { 13, 2, 5, 1, 76, 43, 67 };
            int tmp = 0;
            for(int i = 0; i< array.Length; i++)
            {
                for(int j = 0; j<array.Length - 1 - i; j++)//здесь уменьшение на 1 обязательно
                {                                          //если не уменьшить будет ошибка Out index
                    if (array[j] > array[j+1])              //а -i нужен для того, чтобы не проходиться еще раз уже по остортированной части
                    {
                        tmp = array[j];
                        array[j] = array[j+1];
                        array[j+1] = tmp;
                    }
                }
            }
            for(int i = 0; i< array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }

        //selection sort
        static void SelectionSort()
        {
            int[] array = new int[] { 13, 2, 5, 1, 76, 43, 67 };
            int tmp = 0;
            int min = 0;//index
            for (int i = 0; i < array.Length; i++)
            {
                min = i;
                for (int j = i+1; j < array.Length; j++)
                {                                          
                    if (array[j] < array[min])              
                    {
                        min = j;//находим индекс минимального числа
                    }
                }
                tmp = array[min];
                array[min] = array[i];
                array[i] = tmp; //меняем местами
            }
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }

        //TODO : вернуться
        //Сортировка вставками
        static void SortingByInserts()
        {
            int[] array = new int[] { 13, 2, 5, 1, 76, 43, 67 };
            for(int i = array.Length -1; i > 0; i--)
            {
                for(int j = i + 1; j<array.Length; j++)
                {
                    if(array[i] < array[j])
                    {
                        break;
                    }
                    else
                    {
                        var tmp = array[i];
                        array[i] = array[j];
                        array[j] = tmp;
                    }
                }
            }
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }

        }

        // сдвиг
        static void One()
        {
            var array = new int[] { 13, 2, 5, 1, 76, 43, 67 };
            var index = 2;
            var temp = array[index];
            for (int i = 0; i < array.Length; i++)
            {
                if (index == array.Length - 1)
                {
                    var temp2 = array[0];
                    array[0] = temp;
                    temp = temp2;
                    index = 0;
                }
                else
                {
                    var temp2 = array[index + 1];
                    array[index++ + 1] = temp;
                    temp = temp2;
                }
            }
            foreach (int i in array)
            {
                Console.WriteLine(i);
            }

        }

        //Найдите произведение элементов массива с нечетными номерами
        static void Three() 
        {
            int[] array = new int[] { 2, 2, 4, 2, 57, 2, 45, 2 };
            int mul = 1;
            for (int i = 0; i < array.Length; i++)
            {
                if (i % 2 != 0)
                {
                    mul *= array[i];
                }
            }
            Console.WriteLine(mul);

        }

        //Напишите программу бинарного поиска в массиве целых чисел
        static int Two()
        {
            int key = 4;
            int[] array = new int[] { 2, 2, 4, 2, 57, 2, 45, 2 };
            Array.Sort(array);
            int middle = 0;
            int left = 0;
            int right = array.Length - 1;
            do
            {
                middle = (left + right) / 2;
                if (key > left)
                {
                    left = middle + 1;
                }
                else
                {
                    right = middle - 1;
                }
            } while (left <= right && array[middle] != key);

            if (array[middle] == key)
            {
                return middle;
            }
            else
            {
                return -1;
            }
        }

    }
}
