using System;
using System.Linq;

namespace _15._06._22
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 2, 4, 6,4,8,3,7,1 };
            int i = 0;
            int max = 0;
            int min = arr[0];
            //Console.WriteLine(Sum(arr, s));

            //Console.WriteLine(Count(arr,0));
            //Console.WriteLine(MaxNum(arr,i,max));
            //Console.WriteLine(MinNum(arr, i, min));
            //Short();
            //int index = int.Parse(Console.ReadLine());
            //Console.WriteLine(Short("1", 1, index,"1"));
            Palindrom();
        }
        
        //Ex1
        static int Sum(int[] array,int s)
        {
            if(s >= array.Length)
            {
                return 0;
            }
            else
            {
                int res = Sum(array,s+1);
                return array[s] + res;
            }
        }
        
        //Напишите рекурсивную функцию для подсчета элементов в списке.
        static int Count(int[] array , int i)
        {
            if (array.Length == i)
            {
                return i;
            }
            else
            {
                return Count(array, ++i);
            }
        }

        //Найдите наибольшее число в списке. 
        static int MaxNum(int[] array, int i , int max)
        {
            if (array.Length == i)
            {
                return max;
            }
            else
            {
                if (max < array[i])
                {
                    max = array[i];
                }
                return MaxNum(array, ++i,max);
            }
        }

        //Найти наименьшее число
        static int MinNum(int[]array, int i , int num)
        {
            if (array.Length == i)
            {
                return num;
            }
            else
            {
                if(num > array[i])
                {
                    num = array[i];
                }
                return MinNum(array, ++i, num);
            }
        }

        //Короткая последовательность решить.простые числа.
        static int Short(string num, int i, int index,string num2)
        {
            if(num2.Length >= index)
            {
                return int.Parse(num2[index -1].ToString());
            }
            else
            {
                return Short(num +  ++i, i,index, num2 + num + i);
            }

        }

        //Палиндром через 1 цикл
        static void Palindrom()
        {
            string number = "111101111";
            char[] num = number.ToCharArray();
            int i = 0;
            for (i = 1; i <= num.Length/2; i++)
            {
                if (num[ i - 1 ] != num[num.Length - i])
                {
                    i = -1;
                    break;
                }
            }
            if (i == -1)
            {
                Console.WriteLine("NET");
            }
            else
            {
                Console.WriteLine("DA");
            }
        }
        //Фибоначчи решить
        //Простые числа

    }
}
