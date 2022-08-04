using System;

namespace _05._07._22
{
    class Program
    {
        static void Main(string[] args)
        {
            One();
        }

        //You are climbing a staircase. It takes n steps to reach the top.
        //Each time you can either climb 1 or 2 steps.In how many distinct ways can you climb to the top?
        static int ClimbStairs(int n)
        {
            return default;
        }

        //От перестановки что-то меняется
        static void One()
        {
            var reply = Console.ReadLine().Split(' ');
            int a1 = int.Parse(reply[0]);
            int a2 = int.Parse(reply[1]);
            int a3 = int.Parse(reply[2]);   
            if (a1 + a2 == a3 || a1 + a3 == a2 || a3+a2 == a1)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
