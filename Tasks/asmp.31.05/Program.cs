using System;
using System.IO;
using System.Linq;

namespace asmp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Squirrel();
            //Fedor();
            //Console.WriteLine(Palindrom());
            //Palindrom();
            //Console.WriteLine(Equals());
            //Enia();
            //HarryLarry();
            //Salary();
            //PalindromNum();
            //ReverseArray();
            PalindromWithReverseArray();
        }

        #region Глухой телефон
        static void First()
        {
            string file = "INPUT.TXT";
            string file2 = "OUTPUT.TXT";
            string text = "";
            using (StreamReader reader = new StreamReader(file))
            {
                text = reader.ReadToEnd();
            }

            using (StreamWriter writer = new StreamWriter(file2))
            {
                writer.Write(text);
            }
        }

        static void FirstSimple()=> Console.Write(Console.ReadLine());//Можно без файлов
        #endregion

        #region A+B

        static void AB()
        {
            var res = Console.ReadLine().Split(' ');
            Console.WriteLine(int.Parse(res[0]) + int.Parse(res[1]));
        }
        #endregion

        #region Бусины Принцип Дирихле.
        static void Beads()
        {
            int num = int.Parse(Console.ReadLine());
            Console.Write(num++);
        }
        #endregion

        #region  Федоров
        static void Fedor()
        {
            var res = Console.ReadLine().Split(' ');
            int a = int.Parse(res[0]);
            int b = int.Parse(res[1]);
            for (int i = a; i <= b; i++)
            {
                for(int j = 2; j <= b/2; j++)
                {
                    if(i % j != 0){
                        Console.WriteLine(i);
                        break;
                    }
                }
            }

        }
        #endregion

        #region Palindrom
        static string Palindrom()
        {
            string number = "1000";
            char[] array = number.ToCharArray();
            char[] array2 = array.Reverse().ToArray();
            bool isPalindrom = true;
            for (int i = 0; i < array.Length; i++)
            {
                if(array[i] != array2[i])
                {
                    isPalindrom = false;
                    break;
                }
                isPalindrom = true;
            }
            
            if (isPalindrom)
            {
                return "YES";
            }
            else {
                return "NO";
            }
            
        }

        static void PalindromNum()    
        {
            string number = "132";
            char[] array = number.ToCharArray();
            char[] array2 = array.Reverse().ToArray();
            int i = 0;
            for (i = 0; i < array.Length; i++)
            {
                if (array[i] == array2[i])
                {
                    continue;
                }
                break;
            }
            if(i== array.Length)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }

        }

        static void PalindromWithReverseArray()
        {
            string number = "23";
            char[] array = number.ToCharArray();
            int i = 0;
            int j = array.Length - 1;
            for (i = 0; i < array.Length; i++)
            {
                if(array[i] !=array[j--])
                {
                    break;
                }
            }
            if (i == array.Length)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
        #endregion

        #region Equals 
        //Запишите в выходной файл OUTPUT.TXT один символ "<", если A < B, ">", если A > B и "=", если A=B.
        static string Equals()
        {
            int[] array = new int[2];
            for(int i =0; i<2; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            if (array[0] < array[1]) { return "<"; }
            if (array[0] > array[1]) { return ">"; }
            else { return "="; }
        }
        #endregion

        #region Squirrel
        static void Squirrel()  
        {
            string[] array = Console.ReadLine().Split(' ');
            var n = int.Parse(array[0]);
            var m = int.Parse(array[1]);
            var k = int.Parse(array[2]);
            if(n*m >= k)
            {
                Console.Write("YES");
            }
            else
            {
                Console.Write("NO");
            }

        }
        #endregion

        #region Enia

        static void Enia()
        {
            string[] array = Console.ReadLine().Split(' ');
            Console.Write(int.Parse(array[0]) * ((int.Parse(array[1]) * int.Parse(array[2])) *2) );
        }
        #endregion

        #region Students
        static void Students()
        {
            string[] array = Console.ReadLine().Split(' ');
            Console.Write(1);
        }
        #endregion

        #region Gulliver
        static void Gulliver()
        {
            string[] array = Console.ReadLine().Split(' ');
            Console.Write((int.Parse(array[0])* int.Parse(array[0])) * int.Parse(array[1]));
        }

        #endregion

        #region Harry Larry
        
        static void HarryLarry()
        {
            string[] array = Console.ReadLine().Split(' ');
            int n = int.Parse(array[0]) + int.Parse(array[1]) - 1;
            Console.Write($"{n - int.Parse(array[0])} {n - int.Parse(array[1])}");

        }
        #endregion

        #region Salary
        static void Salary()
        {
            var array = Console.ReadLine().Split(' ');
            int[] salary = new int[array.Length];
            for(int i = 0; i<salary.Length; i++)
            {
                salary[i] = int.Parse(array[i]);
            }
            int max = salary[0];
            int min = salary[0];

            for (int i = 0; i < salary.Length; i++)
            {
                if (salary[i] < min)
                {
                    min = salary[i];
                }
                if (salary[i] > max)
                {
                    max = salary[i];
                }
            }
            Console.WriteLine(max - min);
        }
        #endregion

        #region Reverse Array 
        static void ReverseArray()
        {
            int[] array = new int[] { 1, 56, 8, 3, 9 };
            for(int i = array.Length-1; i >= 0; i--)
            {
                Console.WriteLine(array[i]);
            }
        }
        #endregion
    }
}
