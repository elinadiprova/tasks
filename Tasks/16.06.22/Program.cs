using System;

namespace _16._06._22
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 5;
            int s = 0;
            int[] arr = new int[] { 2, 3, 4, 5, 6, 7 };
            DateTime date = DateTime.Now;
            //Console.WriteLine(One(n));
            //Console.WriteLine(Two(2154, 458));
            //Console.WriteLine(Three(10, 18));
            //Console.WriteLine(Four(arr,0));
            Console.Write(date.Day);

        }


        //Напишите программу для вычисления факториала числа.
        static int One(int n )
        {
            if(n == 1)
            {
                return 1;
            }
            else
            {
                return n *One(n - 1);
            }
        }

        //Найдите наибольший общий делитель двух положительных чисел
        static int Two(int a, int b)
        {

            if (b == 0)
            {
                return a;
            }
            else
            {
                return Two(b, a % b );
            }
        }

        //Напишите программу, чтобы получить целые числа в диапазоне (x, y).
        static int Three(int x, int y)
        {
            if (x < y)
            {
                Console.Write($"{x} ");
                return Three(++x, y);
            }
            else
            {
                return y;
            }
        }

        //Вычислите сумму массива целых чисел
        static int Four(int[] arr, int i)
        {
            if (i >= arr.Length)
            {
                return 0;
            }
            else
            {
                int res = Four(arr, i+1);
                return res + arr[i];
                
            }
            
        }

        //Вычислите экспоненту числа
        static void Five()
        {

        }
    }
}
