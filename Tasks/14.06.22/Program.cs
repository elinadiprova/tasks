using System;

namespace _14._06._22
{
    class Program
    {
        static void Main(string[] args)
        {
            //Factorial(6);
            ShortSequence();
        }

        #region Factorial
        static void Factorial(int n)
        {
            int fact = 1;
            while (n != 1)
            {
                fact *= n;
                n--;
            }
            Console.WriteLine(fact);
        }
        #endregion

        #region Короткая последовательность
        static void ShortSequence()
        {
            var index = int.Parse(Console.ReadLine()); 
            var N = "112123123412345123456123456712345678123456789123456789101234567891011123456";
            char[] array = N.ToCharArray();
            var num = ' ';
            for(int i = 0; i <  array.Length; i++)
            {
                if(i == index)
                {
                    num =array[i - 1];
                    break;
                }
            }
            Console.WriteLine(num);
        }

        #endregion
    }
}
