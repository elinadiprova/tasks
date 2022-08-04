using System;
using System.Linq;

namespace _31._05._22
{
    class Program
    {
        static void Main(string[] args)
        {
            //OneWithStartWith();
            //OneWithCharArray();
            //Two();
            //Three();
            //Four();
            //Delete();
            //DeleteWithoutLinq();
            //DeleteWithSolution();
            //PosledWithLinq();
            PosledWithoutLinqTwo();

            var res = Console.ReadLine().Split().ToArray();
            Console.WriteLine(int.Parse(res[0]) + int.Parse(res[1]));
        }
        #region One

        //Создайте массив из пяти фамилий и выведите их на экран те из них, которые начинаются с определенной буквы, которая вводится с клавиатуры

        static void OneWithStartWith()
        {
            string[] array = new string[] { "Ivanov","Pupkin","Sidorov","Savushkin","Egorov" };
            string target = "S";
            for(int i = 0; i<array.Length; i++)
            {
                if (array[i].StartsWith(target))
                {
                    Console.WriteLine(array[i]);
                }
            }
        }

        static void OneWithCharArray()
        {
            string[] array = new string[] { "Ivanov", "Pupkin", "Sidorov", "Savushkin", "Egorov" };
            string target = "S";
            for (int i = 0; i < array.Length; i++)
            {
                var count = 0;
                for(int j = 0; j<target.Length; j++)
                {
                    if(array[i][j] == target[j])// "I" "S"
                    {   
                        count++;
                        if(count == target.Length) // значит полностью совпадает
                            Console.WriteLine(array[i]);
                    }
                    else
                        break;
                }
            }
        }

        #endregion

        #region Two
        //Найти сумму и произведение элементов одномерного числового массива.

        static void Two()
        {
            int[] array = new int[] { 12, 23, 34, 56, 23, 12 };
            int sum = 0;
            double mul = 1;
            for(int i = 0; i< array.Length; i++)
            {
                sum += array[i];
                mul *= array[i];
            }

            Console.WriteLine($"sum = {sum}");
            Console.WriteLine($"mul = {mul}");
        }

        #endregion

        #region Three
        //Какая сумма элементов массива больше: с первого до элемента с номером К или от элемента с номером К+1 до последнего
        static void Three()
        {
            int[] array = new int[] { 1, 1, 1, 56, 23, 12 };
            int sum1 = 0;
            int sum2 = 0;
            int k = 3;

            for(int i = 0; i <= k; i++)
            {
                sum1 += array[i];
            }
            Console.WriteLine(sum1);
            
            for (int i = k + 1; i < array.Length; i++)
            {
                sum2 += array[i];
            }
            Console.WriteLine(sum2);

        }
        #endregion

        #region Four
        //Введите с клавиатуры пять целочисленных элементов массива X. Выведите на экран значения корней и квадратов каждого из элементов массива.

        static void Four()
        {
            Console.WriteLine("Input Array Size");
            int size = int.Parse(Console.ReadLine());
            int[] array = new int[size];
            for (int i = 0;i<array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("-----------------------------------");
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"SQRT {array[i]} =  {Math.Sqrt(array[i])} ; POW {array[i]} = {Math.Pow(array[i],2)}");
            }

        }

        #endregion

        #region Delete
        
        //Имеется одномерный массив, содержащий числа от 0 до 35-ти. Требуется исключить из него все элементы, значения которых меньше 15
        static void Delete()
        {
            int[] array = new int[] { 15, 16, 17, 35, 36, 19, 7, 5 };
            array = array.Where(val => val> 15 ).ToArray();

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }

        }

        static void DeleteWithoutLinq() 
        {
            int[] array = new int[] { 15, 16, 17, 35, 36, 19, 7, 5 };
            int[] array2;
            int length = 0;
            for(int i = 0; i < array.Length; i++)
            {
                if(array[i] >= 15)
                {
                    length++;
                }
            }
            array2 = new int[length];
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] >= 15)
                {
                    array2[count] = array[i];
                    count++;
                }
            }

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }
            Console.WriteLine();
            for (int i = 0; i < array2.Length; i++)
            {
                Console.Write($"{ array2[i]} ");
            }
        }

        //m - счетчик ++ когда удовлетворяют условию
        static void DeleteWithSolution()
        {
            int[] array = new int[] {1, 3,123,11, 15, 16, 17, 35, 36, 19, 7, 5 };
            var m = 0;
            for(var i = 0; i < array.Length; i++)
            {
                if (array[i] >= 15)
                {
                    array[m] = array[i];
                    m++;
                }
            }

            for (int i = 0; i < m; i++)
            {
                Console.Write($"{array[i]} ");
            }
        }
        #endregion

        #region Posledovatelnost

        //Найти в массиве самую длинную последовательность, состоящую из одинаковых элементов.
        //Вывести на экран количество элементов самой длиной последовательности и номер элемента, который является ее началом.

        static void PosledWithLinq()
        {
            int[] array = new int[] { 0, 1, 1, 1, 0, 0, 1, 0, 1, 1, 1, 1, 1, 0, 0, 0, 1, 0, 1, 0 };

            var a = string.Join("", array);

            var m = a.Split("1").Max().Length > a.Split("0").Max().Length ? a.Split("1").Max(): a.Split("0").Max();

            Console.WriteLine(Math.Max(a.Split("1").Max().Length, a.Split("0").Max().Length));
            Console.WriteLine(a.IndexOf(m));

        }
        static void PosledWithoutLinqTwo()  
        {
            int[] array = new int[] { 0, 1, 1, 0, 0, 1, 0, 1, 1, 1, 1, 0, 0, 0, 1, 0, 1,0,0,0};
            var max = 0;//макс последовательность
            var count = 1;//текущая последовательность
            var index = 0;
            int i;
            for (i = 0; i < array.Length - 1; i++)
            {
                if (array[i] == array[i + 1])
                {
                    count++;
                }
                else
                {
                    if(max < count)
                    {
                        index = i - (count - 2);
                    }
                    max = max > count ? max : count;
                    count = 1;
                }
            }
            if (max < count)
            {
                index = i - (count - 2);
            }
            max = max > count ? max : count;

            Console.WriteLine(max);
            Console.WriteLine(index);
            Console.WriteLine(array.Length);

        }
        #endregion
    }
}
