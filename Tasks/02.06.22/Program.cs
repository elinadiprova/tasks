using System;

namespace _02._06._22
{
    class Program
    {
        static void Main(string[] args)
        {
            //One();
            //Two();
            //Three();
            //Four();
            //Five();
            //Six();
            //Seven();
            //Eight();
            //Nine();
            //Ten();
            //Eleven();
            //Twelve();
            //Thirteen();
            //Fourteen();
            //Fifteen();
            //Seventeen();
            //Eighteen();
            //Nineteen();
            //Twenty();
            //TwentyOne();
            //TwentyTwo();
            //TwentyThree();
            //TwentyFour();
            //TwentyFive();
            //TwentySeven();
            //TwentyEight();
            //TwentyNine();
            //Thirty();
            //ThirtyOne();
            //ThirtyThree();
            //ThirtyFour();
            //ThirtyFive();
            //ThirtySix();
        }

        #region One
        //В заданном массиве чисел найти (посчитать) количество положительных и количество отрицательных элементов.
        //Например, задан массив целых чисел [10, -5, 3, 2, 0, -1, 8, 0, 10, 3]. В нем 6 положительных и 2 отрицательных элемента (нули ни к тем, ни к другим не относятся).
        static void One()
        {
            int[] array = new int[] { 10, -5, 3, 2, 0, -1, 8, 0, 10, 3 };
            int pos = 0;
            int neg = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                {
                    pos++;
                }
                if (array[i] < 0)
                {
                    neg++;
                }
            }
            Console.WriteLine($"Count of positive elements {pos}");
            Console.WriteLine($"Count of negative elements {neg}");

        }
        #endregion

        #region Two
        //Дан массив целых чисел. Проверить, есть ли в нем одинаковые элементы.
        static void Two()
        {
            int[] array = new int[] { 10, -5, 3, 2, 0, -1, 8, 0, 10, 3 };
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] == array[j])
                    {
                        Console.WriteLine(array[i]);
                    }
                }
            }

        }

        #endregion

        #region Three
        //В массиве чисел найти два максимальных элемента.
        // Можно ли сделать это одним циклом? правильная ли проверка? 
        static void Three()
        {
            int[] array = new int[] { 12,9,4,3,9,23,89,2, 89 };
            int max1 = array[0];
            int index = 0;
            int max2 = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max1)
                {
                    max1 = array[i];
                    index = i;
                }
            }
            for (int i = 0; i < array.Length; i++)
            {
                if(i == index)
                {
                    continue;
                }
                if (array[i] > max2)
                {
                    max2 = array[i];
                }
            }
            Console.WriteLine($"max1 = {max1}; max2 = {max2}");
        }
        #endregion

        #region Four
        // Создайте массив А[1..7] с помощью генератора случайных чисел и выведите его на экран. Увеличьте все его элементы в 2 раза.
        static void Four()
        {
            Random rnd = new Random();
            int[] array = new int[7];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(1, 20) * 2;
            }

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
        #endregion

        #region Five
        // Создайте массив А[1..8] с помощью генератора случайных чисел с элементами от –10 до 10 и выведите его на экран.
        //Подсчитайте количество отрицательных элементов массива.
        static void Five()
        {
            Random rnd = new Random();
            int[] array = new int[8];
            int neg = 0;
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(-10, 10);
            }

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    neg++;
                }
            }
            Console.WriteLine(neg);
        }
        #endregion

        #region Six
        //Создайте массив А[1..12] с помощью генератора случайных чисел с элементами от –20 до 10 и выведите его на экран.
        //Замените все отрицательные элементы массива числом 0.
        static void Six()
        {
            Random rnd = new Random();
            int[] array = new int[12];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(-20, 10);
                if (array[i] < 0)
                {
                    array[i] = 0;
                }
            }

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
        #endregion

        #region Seven
        //Создайте целочисленный массив А[1..15] с помощью генератора случайных чисел с элементами от –15 до 30 и выведите его на экран.
        //Определите самый большой элемент массива и его индекс.
        static void Seven()
        {
            Random rnd = new Random();
            int[] array = new int[15];
            int index = 0;
            int max = 0;
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(-15, 30);
                Console.Write($"{array[i]} ");
            }
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                    index = i;
                }
            }
            Console.Write($"MAX = {max}; INDEX = {index}");
        }
        #endregion

        #region Eight
        //Введите с клавиатуры в массив пять целочисленных значений. Выведите их в одну строку через запятую. Получите для массива среднее арифметическое.
        static void Eight()
        {
            int[] array = new int[] { 1, 3, 2, 5, 7 };
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            Console.Write(string.Join(",", array));
            Console.WriteLine($"\navg {sum / array.Length}");
        }
        #endregion

        #region Nine
        //Введите с клавиатуры пять целочисленных элементов массива X. Выведите на экран значения корней и квадратов каждого из элементов массива.
        static void Nine()
        {
            int[] array = new int[] { 5, 14, 67, 23, 25 };
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"sqrt = {Math.Round(Math.Sqrt(array[i]), 2)} pow = {Math.Round(Math.Pow(array[i], 2), 2)}");
            }
        }
        #endregion

        #region Ten
        //Создайте массив из пяти фамилий и выведите их на экран столбиком, начиная с последней.
        static void Ten()
        {
            string[] array = new string[] { "Alanov", "Witbe", "Kuplinov", "Zettfil", "Grey" };
            for (int i = array.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(array[i]);
            }
        }
        #endregion

        #region Eleven
        //С 8 до 20 часов температура воздуха измерялась ежечасно. Известно, что в течение этого времени температура понижалась.
        //Определите, в котором часу была впервые отмечена отрицательная температура.
        static void Eleven()
        {
            Random rnd = new Random();
            int[] array = new int[12];
            int hour = 0;
            int min = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(-5, 5);
            }
            for (int i = 0; i < array.Length; i++)
            {
                if (min > array[i])
                {
                    min = array[i];
                    hour = i;
                }
            }
            Console.WriteLine("====");
            Console.WriteLine(min);
            Console.WriteLine(hour);
        }
        #endregion

        #region Twelve
        //Данные о температуре воздуха за декаду ноября хранятся в массиве. Определить, сколько раз температура опускалась ниже –10 градусов.
        static void Twelve()
        {
            Random rnd = new Random();
            int[] array = new int[10];
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(-20, -5);
                if (array[i] < -10)
                {
                    count++;
                }
            }
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
            Console.WriteLine(count);
        }
        #endregion

        #region Thirteen
        //Данные о температуре воды на Черноморском побережье за декаду сентября хранятся в массиве. Определить, сколько за это время было дней, пригодных для купания.
        static void Thirteen()
        {
            Random rnd = new Random();
            int[] array = new int[10];
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(-10, 20);
                if (array[i] > 15)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
        #endregion

        #region Fourteen
        //Данные о температуре воздуха и количестве осадков за декаду апреля хранятся в массивах.
        //Определить количество осадков, выпавших в виде дождя и в виде снега за эту декаду.
        static void Fourteen()
        {
            string[] array = new string[] { "rain", "snow", "rain", "snow", "rain", "rain", "rain", "rain", "snow", "sun" };
            int snow = 0;
            int rain = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == "snow")
                {
                    snow++;
                }
                if (array[i] == "rain")
                {
                    rain++;
                }
            }
            Console.WriteLine($"Snow count = {snow}; Rain count = {rain}");
        }
        #endregion

        #region Fifteen
        //Данные о температуре воздуха за декаду декабря хранятся в массиве. Определить, сколько раз температура была выше средней за эту декаду..
        static void Fifteen()
        {
            int[] array = new int[] { -10, -5, -15, -2, 0, 12, -5, -3, 1, -4 };
            double avg = 0;
            double sum = 0;
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            avg = sum / array.Length;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > avg)
                {
                    count++;
                }
            }
            Console.WriteLine(avg);
            Console.WriteLine(count);

        }
        #endregion

        #region Sixteen
        //двумерный?
        //Данные о направлении ветра (северный, южный, восточный, западный) и силе ветра за декаду ноября хранятся в массиве.
        //Определить, сколько дней дул южный ветер с силой, превышающей 8 м/с.
        static void Sixteen()
        {

        }
        #endregion

        #region Seventeen
        //Сформируйте линейный массив вещественных чисел, элементы которого являются расстояниями, пройденными телом при свободном падении на землю за 1, 2, … , 10 с.
        static void Seventeen()
        {
            double[] array = new double[11];
            double g = 9.8;
            for (int i = 1; i < array.Length; i++)
            {
                array[i] = Math.Round((Math.Pow(i, 2) * g / 2), 2);
                Console.WriteLine(array[i]);
            }

        }
        #endregion

        #region Eighteen
        //Дан линейный массив целых чисел. Проверьте, является ли он упорядоченным по убыванию.
        //можно просто отсортировать массив по убыванию и сравнить 2 массива
        static void Eighteen()
        {
            Random rnd = new Random();
            int[] array = new int[] { 5,4,3,2,1,3};
            bool sort = true;
            for (int i = 0; i < array.Length-1; i++)
            {
                if (array[i] > array[i + 1])
                {
                    sort = true;
                }
                else
                {
                    sort = false;
                }
            }
            if (sort)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }


        }
        #endregion

        #region Nineteen
        //Найти сумму положительных элементов линейного массива целых чисел. Размерность массива – 10. Заполнение массива осуществить с клавиатуры.
        static void Nineteen()
        {
            int[] array = new int[10];
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < array.Length; i++)
            {
                if(array[i] > 0)
                {
                    sum += array[i];
                }
            }
            Console.WriteLine(sum);
        }
        #endregion

        #region Twenty
        //Найти сумму четных элементов массива целых чисел. Размерность массива – 20. Заполнение массива осуществить случайными числами от 100 до 200.
        static void Twenty()
        {
            Random rnd = new Random();
            int[] array = new int[20];
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(100,200);
            }
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    sum += array[i];
                }
            }
            Console.WriteLine(sum);
        }
        #endregion

        #region Twenty One
        //Найти произведение элементов массива целых чисел, которые кратны 7. Размерность массива – 15.
        //Заполнение массива осуществить случайными числами от 10 до 50.
        static void TwentyOne()
        {
            Random rnd = new Random();
            int[] array = new int[15];
            int mul = 1;
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(10, 50);
                Console.WriteLine(array[i]);
            }
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 7 == 0)
                {
                    mul *= array[i];
                }
            }
            Console.WriteLine($"Mul = {mul}");
        }
        #endregion

        #region Twenty Two
        //21. Найти сумму элементов массива вещественных чисел, имеющих нечетные номера.
        //Размерность массива – 20. Заполнение массива осуществить случайными числами от 100 до 200.
        static void TwentyTwo()
        {
            Random rnd = new Random();
            int[] array = new int[20];
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(100, 200);
                Console.WriteLine(array[i]);
            }
            for (int i = 0; i < array.Length; i++)
            {
                if (i % 2 != 0)
                {
                    sum += array[i];
                }
            }
            Console.WriteLine($"sum = {sum}");
        }
        #endregion

        #region Twenty Three
        //Найти произведение всех элементов массива целых чисел, меньших 0. Размерность массива – 10. Заполнение массива осуществить с клавиатуры.
        static void TwentyThree()
        {
            int[] array = new int[10];
            int mul = 1;
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    mul *= array[i];
                }
            }
            Console.WriteLine($"mul = {mul}");
        }
        #endregion

        #region Twenty Four
        //Найти сумму всех элементов массива целых чисел, удовлетворяющих условию: остаток от деления на 2 равен 3.
        //Размерность массива – 20. Заполнение массива осуществить случайными числами от 200 до 300.
        static void TwentyFour()
        {
            Random rnd = new Random();
            int[] array = new int[20];
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(200, 300);
                Console.WriteLine(array[i]);
            }
            for (int i = 0; i < array.Length; i++)
            {
                if (i % 2 == 3)
                {
                    sum += array[i];
                }
            }
            Console.WriteLine($"sum = {sum}");
        }
        #endregion

        #region Twenty Five
        //24. Найти сумму всех элементов массива вещественных чисел, больших заданного числа.
        //Размерность массива – 20. Заполнение массива осуществить случайными числами от 50 до 100.
        static void TwentyFive()
        {
            Random rnd = new Random();
            int[] array = new int[20];
            int sum = 0;
            int number = 90;
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(50, 100);
                Console.WriteLine(array[i]);
            }
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > number)
                {
                    sum += array[i];
                }
            }
            Console.WriteLine($"sum = {sum}");
        }
        #endregion

        #region Twenty Six
        //25. Найти произведение всех элементов массива вещественных чисел, меньших заданного числа.
        //Размерность массива –10. Заполнение массива осуществить случайными числами от 50 до 100.
        static void TwentySix()
        {
            Random rnd = new Random();
            int[] array = new int[20];
            int sum = 0;
            int number = 90;
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(50, 100);
                Console.WriteLine(array[i]);
            }
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < number)
                {
                    sum += array[i];
                }
            }
            Console.WriteLine($"sum = {sum}");
        }
        #endregion

        #region Twenty Seven
        //Найти произведение элементов массива, кратных 3 и 9. Размерность массива – 10. Заполнение массива осуществить случайными числами от 5 до 500.
        static void TwentySeven()
        {
            Random rnd = new Random();
            int[] array = new int[10];
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(5, 500);
                Console.WriteLine(array[i]);
            }
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 3 == 0 && array[i] % 9 == 0)
                {
                    sum += array[i];
                }
            }
            Console.WriteLine($"sum = {sum}");
        }
        #endregion

        #region Twenty Eight
        //Найти сумму всех элементов массива целых чисел, которые меньше среднего арифметического элементов массива.
        //Размерность массива –20. Заполнение массива осуществить случайными числами от 150 до 300.
        static void TwentyEight()
        {
            Random rnd = new Random();
            int[] array = new int[20];
            int sum = 0;
            int sum2 = 0;
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(150, 300);
                Console.WriteLine(array[i]);
                sum += array[i];
            }
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < sum/array.Length)
                {
                    sum2 += array[i];
                }
            }
            Console.WriteLine($"sum = {sum2} ; avg {sum/array.Length}");
        }
        #endregion

        #region Twenty Nine
        //Найти сумму элементов массива целых чисел, которые делятся на 5 и на 8 одновременно.
        //Размерность массива –30. Заполнение массива осуществить случайными числами от 500 до 1000.
        static void TwentyNine()
        {
            Random rnd = new Random();
            int[] array = new int[30];
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(500, 1000);
                Console.WriteLine(array[i]);
            }
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 5 == 0 && array[i] % 8 == 0)
                {
                    sum += array[i];
                }
            }
            Console.WriteLine($"sum = {sum}");
        }
        #endregion

        #region Thirty
        //Найти произведение элементов линейного массива целых чисел, которые кратны 5.
        //Размерность массива –10. Заполнение массива осуществить случайными числами от 10 до 100.
        static void Thirty()
        {
            Random rnd = new Random();
            int[] array = new int[10];
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(10, 100);
                Console.WriteLine(array[i]);
            }
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 5 == 0)
                {
                    sum += array[i];
                }
            }
            Console.WriteLine($"sum = {sum}");
        }
        #endregion

        #region Thirty One
        // Рассортируйте заданный линейный массив по возрастанию.
        static void ThirtyOne()
        {
            int[] array = new int[] { 6, 4, 1, 5, 3, 7, 8, 12, 1, 23 };
            int tmp = 0;
            for(int i = 0; i<array.Length; i++) //i - номер прохода
            {
                for (int j = array.Length - 1; j > i; j--) 
                { 
                    if (array[j - 1] > array[j])
                    {
                        tmp = array[j - 1];
                        array[j - 1] = array[j];
                        array[j] = tmp;
                    }
                }
            }
            for (int i = 0; i < array.Length - 1; i++)
            {
                Console.WriteLine(array[i]);
            }

        }
        #endregion

        #region Thirty Two
        //Найти количество четных элементов одномерного массива.
        static void ThirtyTwo()
        {
            Random rnd = new Random();
            int[] array = new int[10];
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(10, 100);
                Console.WriteLine(array[i]);
            }
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    count++;
                }
            }
            Console.WriteLine($"sum = {count}");
        }
        #endregion

        #region Thirty Three
        //Найти количество четных элементов одномерного массива до первого встреченного числа равного наперед заданному числу а.
        static void ThirtyThree()
        {
            Random rnd = new Random();
            int[] array = new int[20];
            int count = 0;
            int a = 12;
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(10, 15);
                Console.WriteLine(array[i]);
            }
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0 && array[i] != a)
                {
                    count++;
                }
                if (array[i] == a)
                {
                    break;
                }
            }
            Console.WriteLine($"count = {count}");
        }
        #endregion

        #region Thirty Four
        //Вычислить среднее арифметическое значение тех элементов одномерного массива, которые расположены за первым по порядку минимальным элементом.
        static void ThirtyFour()
        {
            Random rnd = new Random();
            int[] array = new int[10];
            int min = 0;
            int count = 0;
            int sum = 0;
            int index = 0;
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(1, 15);
            }
            min = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (min > array[i])
                {
                    min = array[i];
                    index = i;
                }
            }
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
            Console.WriteLine($"min = {min}");

            for (int i = index; i < array.Length; i++)
            {
                sum += array[i];
                count++;
            }
            if(count == 0)
            {
                Console.WriteLine("count = 0!");
            }
            else
            {
                Console.WriteLine($"avg = {sum / count}");

            }
        }
        #endregion

        #region Thirty Five
        // Вычислить среднее арифметическое значение тех элементов одномерного массива, которые попадают в интервал от –2 до 10.
        static void ThirtyFive()
        {
            Random rnd = new Random();
            int[] array = new int[10];
            int count = 0;
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(-2, 15);
                Console.WriteLine(array[i]);
            }
            for(int i = 0; i < array.Length; i++)
            {
                if(array[i] > -2 && array[i] < 10)
                {
                    sum += array[i];
                    count++;
                }
            }
            Console.WriteLine($"avg = {sum / count}");
        }
        #endregion

        #region Thirty Six
        // Переменной t присвоить значение истина, если в одномерном массиве имеется хотя бы одно отрицательное и четное число.
        static void ThirtySix()
        {
            Random rnd = new Random();
            int[] array = new int[10];
            bool t = false;
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(-5, 10);
                Console.WriteLine(array[i]);
            }
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0 && array[i] %2 == 0 )
                {
                    t = true;
                    break;
                }
            }
            Console.WriteLine(t);
        }
        #endregion
    }
}
