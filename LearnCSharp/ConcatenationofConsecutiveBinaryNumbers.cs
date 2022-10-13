using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCSharp
{
    class ConcatenationofConsecutiveBinaryNumbers
    {
        public string ConcatenationofBinaryNumbers(int i)
        {
            string s = convertToBinary(i);
            return convertBinaryToDecimal(s);

        }
        public string convertBinaryToDecimal(string s)
        {
            Char[] c = s.ToCharArray();
            int iCtr = s.Length;
            double result = 0;
            foreach (Char c1 in c)
            {
                iCtr--;
                result += Math.Pow(2, iCtr) * Convert.ToInt32( c1.ToString());
            }
            result = result % (Math.Pow(10, 9) + 7);
            print(result.ToString());
            return result.ToString();
        }
        string convertToBinary(int n)
        {
            StringBuilder result = new StringBuilder();
            int i = 1;
            while ( i <= n)
            {
                result.Append (getBinary(i));
                i++;
            }
            return result.ToString();
        }

        string getBinary(int i)
        {
            int rem = i % 2;
            int res = i / 2;
            StringBuilder result = new StringBuilder( rem.ToString());
            while (res  > 1)
            {
                rem = res % 2;
                res = res / 2;
                result.Append(rem.ToString());
            }

            if (res > 0)
            result.Append(res.ToString()).ToString();

            return result.ToString(); //.reversString();
        }
        byte getBytes(int i)
        {
            return Convert.ToByte(i);
        }

        void print(string s)
        {
            Console.WriteLine(s);
        }

        string reversString(string s)
        {
            return s.ToCharArray().Reverse().ToString();
        }

        public string PaddingRight(string s)
        {
            return s.PadRight(5);
        }
    }
}


