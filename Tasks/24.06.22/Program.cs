using System;
using System.Globalization;

namespace _24._06._22
{
    class Program
    {
        static void Main(string[] args)
        {
            string RUmonth = DateTime.Now.ToString("dddd;d;MMMM;yyyy", CultureInfo.GetCultureInfo("ru-ru"));
            string[] arr = RUmonth.Split(';');
            //for(int i = 0; i< arr.Length; i++)
            //{
            //    Console.WriteLine(arr[i]);
            //}
            

            Console.WriteLine(DateTime.Now.ToString("d",
                  CultureInfo.CreateSpecificCulture("de-DE")));
            Console.WriteLine();
        }

        //баскетбол
        static void One()
        {
            var nums1 = Console.ReadLine().Split(' ');
            var nums2 = Console.ReadLine().Split(' ');
            var nums3 = Console.ReadLine().Split(' ');
            var nums4 = Console.ReadLine().Split(' ');
            var sum1 = int.Parse(nums1[0]) + int.Parse(nums2[0]) + int.Parse(nums3[0]) + int.Parse(nums4[0]);
            var sum2 = int.Parse(nums1[1]) + int.Parse(nums2[1]) + int.Parse(nums3[1]) + int.Parse(nums4[1]);
            if (sum1 > sum2)
            {
                Console.WriteLine(1);
            }
            else if (sum1 < sum2)
            {
                Console.WriteLine(2);
            }
            else
            {
                Console.WriteLine("DRAW");
            }
        }

        //земляника
        static void Berries()
        {
            var nums = Console.ReadLine().Split(' ');
            var sum = int.Parse(nums[0]) + int.Parse(nums[1]);
            if (sum >= int.Parse(nums[2]))
            {
                Console.WriteLine(sum - int.Parse(nums[2]));
            }
            else
            {
                Console.WriteLine("Impossible");
            }
        }

        //торт
        static void Cake()
        {
            int num = int.Parse(Console.ReadLine());
            if(num % 2 == 0)
            {
                Console.WriteLine(num/2);
            }
            else if(num == 1)
            {
                Console.WriteLine(0);
            }
            else
            {
                Console.WriteLine(num);
            }
        }

        //Журавли
        static void Birds()
        {
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine(num / 6+" "+num / 6 * 4 + " "+ num / 6);
        }

        //толстяки
        static void Fats()
        {
            var nums = Console.ReadLine().Split(' ');
            int[] arr = Array.ConvertAll(nums, int.Parse);
            int max = 0;
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
                if (max < arr[i])
                {
                    max = arr[i];
                }
            }
            if (max <= 94 || max >= 727)
            {
                Console.WriteLine("Error");
            }
            else
            {
                Console.WriteLine(max);
            }
        }

        //бинарные числа
        static void Binar()
        {
            int num = int.Parse(Console.ReadLine());
            while (num >= 2)
            {
                if (num % 2 == 0)
                {
                    num = num / 2;
                }
                else { break; }

            }
            Console.WriteLine(num == 1 ? "YES" : "NO");
        }

        //Монетки
        static void Coins()
        {
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            int count1 = 0;
            int count2 = 0;
            for(int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
                if(array[i] == 0)
                {
                    count1++;
                }
                else
                {
                    count2++;
                }
            }

            Console.WriteLine(count2>count1? count2 : count1);
        }

        //Мышка
        static void Mouse()
        {
            var nums = Console.ReadLine().Split(' ');
            Console.WriteLine(int.Parse(nums[2]) *2 <= int.Parse(nums[1]) && int.Parse(nums[2])*2 <= int.Parse(nums[0]) ? "YES" : "NO");
        }
    }
}
