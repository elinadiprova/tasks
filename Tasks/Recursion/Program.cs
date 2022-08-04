using System;

namespace Recursion
{
    class Program
    {
        static void Main(string[] args)
        {
            //RecOne(5, 1);
            //RecTwo(5,1);
            //Console.WriteLine(RecThree(2,2));
            //int four = RecFour(16);
            //Console.WriteLine(four == 1? "Yes" : "No");
            //Console.WriteLine(RecFive(179));
        }

        

        //Дано натуральное число n. Выведите все числа от 1 до n.
        static int RecOne(int num, int i)
        {
            if (i <= num)
            {
                Console.WriteLine(i);
                return RecOne(num, i + 1);
            }
            else
            {
                return num;
            }
        }

        //Даны два целых числа A и В (каждое в отдельной строке). Выведите все числа от A до B включительно, в порядке возрастания,
        //если A < B, или в порядке убывания в противном случае.
        static int RecTwo(int a, int b)
        {
            if(a == b)
            {
                Console.WriteLine(a);
                return a;
            }
            if (a < b)
            {
                Console.WriteLine(a);
                return RecTwo(a+1,b);
            }
            else
            {
                Console.WriteLine(a);
                return RecTwo(--a,b);
            }
            
        }

        //Функция Аккермана
        //Даны два целых неотрицательных числа m и n, каждое в отдельной строке. Выведите A(m,n).
        static int RecThree(int m, int n)
        {
            if (m > 0 && n>0)
            {
                return RecThree(m-1,RecThree(m,n-1));
            }
            if(m > 0 && n == 0)
            {
                return RecThree(m - 1, 1);
            }
            if(m == 0)
            {
                return n + 1;
            }
            else
            {
                return 0;
            }
        }
        //Точная степень двойки
        static int RecFour(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            if(n % 2 == 0)
            {
                return RecFour(n/2);
            }
            else
            {
                return 0;
            }
        }

        //Дано натуральное число N. Вычислите сумму его цифр
        static int RecFive(int n)
        {
            if (n == 0)
            {
                return 0;
            }
            else
            {
                return n % 10 + RecFive(n / 10);
            }
            
        }

        //
        static void RecSix()
        {

        }
    }
}
