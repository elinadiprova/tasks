using System;

namespace _09._06._22
{
    class Program
    {
        static void Main(string[] args)
        {
            //One();
            //Two();
            int n = 2;
            string tes = "ssss" + n;
            Console.WriteLine(tes);
        }

        #region One
        //Али баба
        static void One()
        {
            {
                string[] param = Console.ReadLine().Split(' ');
                string[] numbers = Console.ReadLine().Split(' ');
                int[] array = new int[int.Parse(param[0])];
                int max1 = 0;
                int max2 = 0;
                int maxIndex = 0;
                int count = int.Parse(param[1]);
                int sum = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = int.Parse(numbers[i]);
                }
                max1 = array[0];
                max2 = array[0];
                for (int i = 0; i < array.Length; i++)
                {
                    if (max1 < array[i])
                    {
                        max1 = array[i];
                        maxIndex = i;
                    }
                }
                for (int i = 0; i < array.Length; i++)
                {
                    if (i == maxIndex)
                    {
                        continue;
                    }
                    if (max2 < array[i])
                    {
                        max2 = array[i];
                    }
                }
                Console.WriteLine(max1 + max2);
            }
            #endregion
        }

        #region Two
        //
        static void Two()
        {
            string size = Console.ReadLine();
            var nums = Console.ReadLine().Split(' ');
            int[] array = new int[int.Parse(size)];
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(nums[i]);
            }
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] + 1 == array[i + 1])
                    continue;
                else
                    count++;
            }
            Console.WriteLine(count);

        }
        #endregion

        #region Короткая последовательность
        //Короткая последовательность
        static void Short()
        {

        }
        #endregion
    }
}
