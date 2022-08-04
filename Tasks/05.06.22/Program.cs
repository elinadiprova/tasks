using System;
using System.Linq;

namespace _05._06._22
{
    class Program
    {
        static void Main()
        {
            //One();
            //Two();
            //Three();
            //Four();
            Min();
        }

        #region One
        //Вычислить сумму четных элементов одномерного массива до первого встреченного нулевого элемента.
        static void One()
        {
            int[] array = new int[] { 4,6,12,87,34,0,12,44};
            int sum = 0;
            for(int i = 0; i<array.Length; i++)
            {
                if(array[i] == 0)
                {
                    break;
                }
                else
                {
                    sum += array[i];
                }
            }
            Console.WriteLine(sum);
        }
        #endregion

        #region Two
        //Переменной t присвоить значение истина, если максимальный элемент одномерного массива единственный и не превосходит наперед заданного числа а.
        // оптимизация
        static void Two()
        {
            int[] array = new int[] { 4, 6, 12, 87, 34, 0, 12, 44, 87 };
            int a = 95;
            bool t = false;
            int max = array[0];
            int count = 0;
            for(int i = 0; i<array.Length; i++)
            {
                if(max < array[i])
                {
                    max = array[i];
                }
            }
            for (int i = 0; i < array.Length; i++)
            {
                if (max == array[i])
                {
                    count++;
                }
            }
            if (count == 1 && max < a)
            {
                t = true;
            }
            
            Console.Write(max);
            Console.Write(t);

        }
        #endregion

        #region Three
        //Вставка элемента в массив
        //Требуется добавить элемент в произвольное место массива.
        static void Three()
        {
           
            int[] array = new int[] { 12,34,1,4,6,78,0};
            int size =array.Length -1;
            int num = 95;
            int position = 5;
            
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
            for (int i = size - 1; position <= i; i--)
            {
                array[i + 1] = array[i];
                array[position] = num;
            }

            Console.WriteLine("=====");
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
        #endregion

        #region Four
        //Слияние двух упорядоченных массивов
        static void Four()
        {
            Random rnd = new Random();
            int[] array1 = new int[10];
            int[] array2 = new int[10];
            int[] array3 = new int[array1.Length+array2.Length];
            for(int i = 0; i<array1.Length; i++)
            {
                array1[i] = rnd.Next(1, 20);
            }
            for (int i = 0; i < array2.Length; i++)
            {
                array2[i] = rnd.Next(1, 20);
            }
            Array.Sort(array1);
            Array.Sort(array2);
            int in1 = 0;
            int in2 = 0;
            for(int i = 0; i< array3.Length ; i++)
            {
                if (array1.Length == in1)
                {
                    array3[i] = array2[in2];
                    in2++;
                    continue;
                }
                if (array2.Length == in2)
                {
                    array3[i] = array1[in1];
                    in1++;
                    continue;
                }
                if(array1[in1] > array2[in2])
                {
                    array3[i] = array2[in2];
                    in2++;
                }
                else
                {
                    array3[i] = array1[in1];
                    in1++;
                }
            }

            array3.ToList().ForEach(w => Console.WriteLine(w));
        }
        #endregion

        static void Min()
        {
            int[] a = new int[] { 1, 4, 3, 65, 0 };
            int min = a[0];
            for(int i = 0; i<a.Length; i++)
            {
                if(min > a[i])
                {
                    min = a[i];
                }
            }
            Console.WriteLine(min);

        }
    }
}
