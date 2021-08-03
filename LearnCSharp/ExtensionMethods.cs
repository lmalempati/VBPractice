using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCSharp
{
    static class ExtensionMethods
    {
        public static int GetWordCount(this string s1, char ch )
        {
            string [] words = s1.Split(new[] { ch });
            int i = words.Length;
            return words.Count();
        }

        public static string ReverseString(this string source)
        {
            //return source.ReverseString();
            //char[] chArr = { 'a', 'p', 'p', 'l', 'e' };
            //return chArr.Reverse().ToString();

            //string[] result = new string(source.Length;
            StringBuilder sb = new StringBuilder();

            for (int i = source.Length - 1; i >= 0; i--)
            {
                sb.Append(source[i]);
            }
            return sb.ToString();
        }

        public static void SimpleMath()
        {
            int x = 4, b = 2;
            x -= b /= x * b;
            Console.WriteLine(x + " " + b);
            Console.ReadLine();

            int[] Nums = new int[5] { 1, 2, 3, 4, 5};
            Array.Resize(ref Nums, 6);

            IEnumerable<int> FilNums = Nums.Where((i) => i > 2 ).Select(i => i + 1);

            FilNums = from i in Nums
                      select i + 1;
            
        }
    }
}
