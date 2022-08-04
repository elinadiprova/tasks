using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _28._06._22
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(PalindromeNumber(0));
            //["reflower","flow","flight"]
            //string[] array = new string[] { "reflower", "flow", "flight" };
            //Console.WriteLine(LongestCommonPrefixLinq(array));
            //int[] nums = new int[] { 1, 3, 5, 6 };
            //Console.WriteLine(SearchInsert(nums, 5));
            //Console.WriteLine(LengthOfLastWord("   fly me   to   the moon  "));
            //int[] digits = new int[] { 9, 9};
            //Console.WriteLine(PlusOne(digits));
            Console.WriteLine(MyPow(2.00000, -2));
        

        }

        #region Palindrom
        static bool PalindromeNumber(int x)
        {
            char[] array = x.ToString().ToCharArray();
            bool isPalindrom = false;
            for(int i = 0; i < array.Length; i++)
            {
                if (array[i - 1 + 1] == array[array.Length-i -1])
                {
                    isPalindrom = true;
                }
                else
                {
                    isPalindrom = false;
                    break;
                }
            }
            return isPalindrom;
        }

        public bool IsPalindrome(int x)
        {
            return (x.ToString().SequenceEqual(x.ToString().Reverse()) ? true : false);
        }
        #endregion

        #region TwoSum

        public int[] TwoSum(int[]array,int target)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i+1; j < array.Length; j++)
                {
                    if(array[i] + array[j] == target)
                    {
                        Console.WriteLine($"[{i},{j}]");
                        return new int[] { i,j};
                    }
                }
            }
            return null;
        }

        #endregion

        #region Longest Common Prefix
        static string LongestCommonPrefix(string[] strs)
        {
            var prefix = String.Empty;
            if (strs.Length == 0)
            {
                return "";
            }
            for (int i = 0; i < strs.Length-1; i++)
            {
                var a = Convert(strs[i]);
                var b = Convert(strs[i + 1]);
                var l = a.Length <= b.Length ? a.Length : b.Length;
                for (int j = 0; j < l; j++)
                {
                    if(a[j] == b[j])
                    {
                        if (!prefix.Contains(a[j]))
                        {
                            prefix += a[j];
                        }
                    }
                    else
                    {
                        break;
                    }
                }
            }
            return prefix.Length>=2? prefix : "";

        }
        static string LongestCommonPrefixLinq(string[] strs)    
        {
            int minLength = strs.Min(y => y.Length); 
            string min = strs.FirstOrDefault(x => x.Length == minLength);
            var check = true;
            var tmp = string.Empty;
            for (int i = 0; i < min.Length+1; i++)
            {
                tmp = min.Substring(0, min.Length - i);
                check = true;
                for (int j = 0; j < strs.Length; j++)
                {
                    if (!strs[j].StartsWith(tmp))
                    {
                        check = false;
                        break;
                    }
                }
                if (check)
                {
                    return tmp;
                }
            }
            return tmp;
        }

        static char[] Convert(string word)
        {
            char[] array = word.ToCharArray();
            return array;
        }
        #endregion

        #region
        public int RemoveDuplicatesA(int[] nums)
        {
            return default;
        }
        public int RemoveDuplicates(int[] nums)
        {
            if (nums == null || nums.Length == 0)
                return 0;
            else if (nums.Length == 1)
                return 1;

            int index1 = 0,
                index2 = 1;

            while (index2 <= nums.Length - 1)
                if (nums[index1] == nums[index2])
                    index2++;
                else
                    nums[++index1] = nums[index2++];

            return ++index1;
        }
        #endregion

        // Search Insert Position
        static int SearchInsert(int[] nums, int target)
        {
            int left = 0;
            int right = nums.Length -1;
            int m = 0;
            while (nums[m] != target && left <= right)
            {
                m = (right + left) / 2;
                if (target > nums[m])
                {
                    left = m + 1;
                }
                else
                {
                    right = m - 1;
                }
            }
            if (nums[m] == target)
                return m;
            else
            {
                Array.Resize(ref nums, nums.Length + 1);
                
                nums[nums.Length - 1] = target;
                Array.Sort(nums);
                int index = 0;
                for (int i = 0; i < nums.Length; i++)
                {
                    if (target == nums[i])
                    {
                        index = i;
                    }
                }
                return index;
            }
        }

        //Length of Last Word
        static int LengthOfLastWord(string s)
        {
            s = Regex.Replace(s, @"\s+", " ");
            string[] array = s.Trim().Split(' ').ToArray();
            var t = array.Last();
            return t.Count();
        }
        //Plus One
        static int[] PlusOne(int[] digits)
        {
            int[] array;
            for (int i = digits.Length; i > 0; i--)
            {
                var t = digits[i - 1] + 1;
                if (t >= 10)
                {
                    digits[i - 1] = 0;
                }
                else
                {
                    digits[i -1]++; 
                    break;
                }
            }
            if(digits[0] == 0)
            {
                array = new int[digits.Length +1];
                array[0] = 1;
            }
            else
            {
                array = digits;
            }
            return array;
        }

        static double MyPow(double x, int n)
        {
            if(n == 0)
            {
                return 1;
            }
            else if (n < 0)
            {
                n *= -1;
                return 1.0 / (x*(MyPow(x, n - 1)));
            }
            else
            {
                return x * MyPow(x, n - 1);
            }
        }
    }
}
