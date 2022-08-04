using System;
using System.Collections.Generic;

namespace MyTest
{
    class Program
    {
        public static void Main()
        {
            List<List<string>> lists = new List<List<string>>()
        {
            new List<string>() { "C", "C++" },
            new List<string>() { "Java", "Kotlin" }
        };

            string[,] arrays = new string[lists.Count, lists[0].Count];
            for (int i = 0; i < lists.Count; i++)
            {
                for (int j = 0; j < lists[i].Count; j++)
                {
                    arrays[i, j] = lists[i][j];
                }
            }
            
            // print the 2D array
            foreach (var array in arrays)
            {
                Console.WriteLine(String.Join(", ", array));
            }


        }
    }
}
