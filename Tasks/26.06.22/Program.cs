using System;

namespace _26._06._22
{
    class Program
    {
        static void Main(string[] args)
        {
            //One(1345);
            //Two(1125);
            //Console.WriteLine(Four(33,2));
            Five(90);
        }

        //Цифры числа справа налево
        static int One(int n)
        {
            // n / 10 == 0
            if (n <10)
            {
                Console.WriteLine(n % 10);
                return n;
            }
            else
            {
                Console.WriteLine(n%10);
                return One(n/10);
            }
        }

        //Цифры числа слева направо
        static int Two(int n)
        {
            if (n < 10)
            {
                Console.WriteLine(n % 10);
                return n;
            }
            else
            {
                var res = Two(n / 10);
                Console.WriteLine(n % 10);
                return res;
            }
        }

        static string Four(int n, int count)
        {
            if (n % count == 0 && n != 2 )
            {
                return "NO";
            }
            else
            {
                if(count > n / 2 || n <=3)
                {
                    return "YES";
                }
                return Four(n, ++count); ;
            }
        }

        //Разложение на множители
        static int Five(int n, int num = 2)
        {
            if(n == 1)
            {
                return n;
            }
            else
            {
                if (n % num == 0)
                {
                    Console.WriteLine(num);
                    return Five(n / num);

                }
                else 
                {
                    return Five(n, num+1);
                }
            }
        }
    }
}
