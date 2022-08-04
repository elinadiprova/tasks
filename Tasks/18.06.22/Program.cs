using System;

namespace _18._06._22
{
    class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine(One(11, 18));
            //Console.Write(Two(new int[] { 2, 3, 4, 5, 6, 7 },0));
            //Console.WriteLine(Fib(0, 1, 7));
            // Console.Write(FibEffective(10));
            int n = 100;
            long[] mem = new long[n + 1];
            Array.Fill(mem, -1);
            Console.WriteLine(FibMemo(n,mem));
        }

        //Получите целые числа в диапазоне
        //Пример: диапазон (10, 18)
        //Ожидаемый результат: [11,12,13,14,15,16,17]
        static string One(int x, int y)
        {
            if (x == y-1)
            {
                return x.ToString();
            }
            else
            {
                return x+ " "+ One(++x, y);
            }
        }

        //Вычислите сумму массива целых чисел
        //Пример: var array = [2, 3, 4, 5, 6, 7]
        //27
        static int Two(int[] array,int i)
        {
            if(i== array.Length)
            {
                return 0;
            }
            else
            {
                return array[i]+ Two(array, ++i); 
            }
        }

        ///Получить первые n чисел Фибоначчи
        static string Fib(int n1, int n2,int count)
        {
            if (count == 0)
            {
                return "";
            }
            else
            {
                return n1 + " " + Fib(n2, n1 + n2, --count);
            }
        }

        //по уроку
        //меледнный и очевидный
        static long FibNaive(int n)
        {
            if (n <= 1)
            {
                return n;
            }
            else
            {
                return FibNaive(n - 1) + FibNaive(n - 2);
            }
        }

        //более эффективный алгоритм
        static long FibEffective(int n)
        {
            long[] array = new long[n + 1];
            array[0] = 0;
            array[1] = 1;
            for (int i = 2; i<=n; i++)
            {
                array[i] = array[i - 1] + array[i - 2];
            }
            return array[n];
        }

        //по уроку
        //меледнный и очевидный оптимизировали
        static long FibMemo(int n, long[] mem)
        {   
            if(mem[n] != -1)//будет означать то, что метод FibMemo  с таким аргументом мы вызывали и
                            //вычислять для него него не над и надо просто забрать элемент
            {
                return mem[n];
            }
            if (n <= 1)
            {
                return n;
            }
            else
            {
                long res = FibMemo(n - 1,mem) + FibMemo(n - 2, mem);
                mem[n] = res;
                return res;
            }
        }
    }
}
