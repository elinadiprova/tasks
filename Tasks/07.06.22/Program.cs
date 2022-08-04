using System;
using System.Linq;

namespace _07._06._22
{
    class Program
    {
        static void Main(string[] args)
        {
            //One();
            //Two();
            //Three();
            Four();
        }


        #region One
        //Найдите сумму номеров минимального и максимального элементов.
        static void One()
        {
            int[] array = new int[10];
            Random rnd = new Random();
            int min = 0;
            int max = 0;
            for(int i = 0; i<array.Length; i++)
            {
                array[i] = rnd.Next(1, 10);
            }
            min = array[0];
            max = array[0];

            for(int i = 0; i<array.Length; i++)
            {
                if(min > array[i])
                {
                    min = array[i];
                }
                if(max < array[i])
                {
                    max = array[i];
                }
            }
            array.ToList().ForEach(e => Console.WriteLine(e));
            Console.WriteLine($"min elem = {min} max elem = {max}; sum = {min +max}");


        }
        #endregion

        #region Two
        //Найдите минимальный по модулю элемент массива
        static void Two()
        {
            int[] array = new int[10];
            Random rnd = new Random();
            int min = 0;
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(-10, 10);
            }
            min = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (Math.Abs(min) > Math.Abs(array[i]))
                {
                    min = Math.Abs(array[i]);
                }
            }
            array.ToList().ForEach(e => Console.WriteLine(e));
            Console.WriteLine($"min elem = {min}");
        }
        #endregion

        #region Three ASMP
        //Вася не любит английский язык, но каждый раз старается получить хотя бы четверку за четверть, чтобы оставаться ударником.
        //В текущей четверти Вася заметил следующую закономерность: по нечетным дням месяца он получал тройки, а по четным – четверки.
        //Так же он помнит, в какие дни он получал эти оценки. Поэтому он выписал на бумажке все эти дни для того, чтобы оценить,
        //сколько у него троек и сколько четверок. Помогите Васе это сделать, расположив четные и нечетные числа в разных строчках.
        //Вася может рассчитывать на оценку 4, если четверок не меньше, чем троек.

        //Входные данные
        //В первой строке входного файла INPUT.TXT записано единственное число N – количество элементов целочисленного массива (1 ≤ N ≤ 100).
        //Вторая строка содержит N чисел, представляющих заданный массив.Каждый элемент массива – натуральное число от 1 до 31.
        //Все элементы массива разделены пробелом.

        //Выходные данные
        //В первую строку выходного файла OUTPUT.TXT нужно вывести числа, которые соответствуют дням месяцев, в которые Вася получил тройки,
        //а во второй строке соответственно расположить числа месяца, в которые Вася получил четверки.В третьей строке нужно вывести «YES»,
        //если Вася может рассчитывать на четверку и «NO» в противном случае.В каждой строчке числа следует выводить в том же порядке, в
        //котором они идут во входных данных.При выводе числа отделяются пробелом.
        static void Three()
        {
            int size = int.Parse(Console.ReadLine());
            string[] numbers = Console.ReadLine().Split(' ');
            int[] array = new int[size];
            string ch = "";
            string nech = "";
            for(int i = 0; i<array.Length; i++)
            {
                array[i] = int.Parse(numbers[i]);
            }
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    ch += $"{array[i]} ";

                }
                else
                {
                    nech += $"{array[i]} ";
                }
            }
            string t = "";
            if(nech.Length > ch.Length)
            {
                t = "NO";
            }
            else
            {
                t = "YES";
            }
            Console.WriteLine(nech);
            Console.WriteLine(ch);
            Console.WriteLine(t);
        }
        #endregion

        #region Four ASMP
        //Кризисный бизнес
        //В городе, в котором живет Петр Васильевич, есть только один автосалон. Известно, что в этом автосалоне выставлено на продажу N автомобилей,
        //причем установлено, что стоимость i-го автомобиля равняется Ai. Вашей задачей является помочь еще неопытному бизнесмену Петр Васильевичу
        //приобрести максимальное количество автомобилей, потратив сумму не более S.

        //В первой строке входного файла INPUT.TXT находится два целых положительных числа разделенные одиночным пробелом – это числа N (1 ≤ N ≤ 100) и S (1 ≤ S ≤ 109) соответственно.
        //Вторая строка содержит ровно N чисел Ai(1 ≤ Ai ≤ 109) , которые описывают стоимость соответствующих автомобилей.Все числа в строке разделены одиночными пробелами.
        //В выходной файл OUTPUT.TXT выведите одно целое число – максимальное количество автомобилей, которые сможет приобрести Петр Васильевич на сумму не более чем S.

        static void Four()
        {
            string[] input = Console.ReadLine().Split(' ');
            string[] numbers = Console.ReadLine().Split(' ');
            int size = int.Parse(input[0]);
            int money = int.Parse(input[1]);
            int sum = 0;
            int count = 0;
            int[] array = new int[size];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(numbers[i]);
            }
            Array.Sort(array);

            for(int i = 0; i<array.Length; i++)
            {
                sum += array[i];
                if(sum <= money)
                {
                    count++;
                }
                if (sum > money)
                {
                    sum -= array[i];
                    continue;
                }
                if(sum == money)
                {
                    break;
                }
            }
            Console.WriteLine(count);
        }
        #endregion
    }
}
