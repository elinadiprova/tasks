using System;

namespace _03._07._22
{
    class Program
    {
        static void Main(string[] args)
        {
            One();
        }

        //Переменной t присвоить значение истина, если максимальный элемент одномерного массива единственный и не превосходит
        //наперед заданного числа а.
        static void One()
        {
            int[] array = new int[] {1,23,54,23,87,4,7,34,2 };
            var t = false;
            int a = 0;
            int max = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if(max< array[i])
                {
                    max = array[i];
                }
            }
            Console.WriteLine(t);
        }
    }
}
