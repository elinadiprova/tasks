using System;

namespace _12._06._22
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }

        #region BinarySearch
        static int SearchBinary(int[] a, int x)//массив и искомое значение
        { 
           int m, left = 0, right = a.Length - 1; // left and right -границы массива
           do 
           { 
             m = (left + right) / 2; //середина
             if (x > a[m]) // если искомое число больше половины
             left = m + 1; // то отбрасываем левую часть, то есть сдвигаем ее
             else 
             right = m - 1;//иначе отбрасываем правую часть, то есть сдвигаем ее
           } 
           while ((a[m] != x) && (left <= right)); //делаем до тех пор,пока не найден искомый элемент и левая границы меньше или равно правой
           if (a[m] == x) //если находим, то возвращаем элемент
             return m; 
           else 
             return -1; //иначе просто -1
        } 
        #endregion
    }
}
