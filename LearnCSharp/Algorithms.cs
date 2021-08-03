using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCSharp
{
    public class Algorithms
    {
        // Elucid's algorithm
       public int FindGcd(int a, int b)
        {
            int first, second;
            if (a > b)
            {
                first = a;
                second = b;
            }
            else
            {
                first = b;
                second = a;
            }

            while (second != 0)
            {
                var tmp = first;
                first = second;
                second = tmp % second;
                    }
            Console.WriteLine($"GCD of {a} and {b} is: {first}");
            return first;
        }

        public void FindFibanucciNumber(int Count)
        {
            List<int> FibNums = new List<int> { 0, 1 };
            for (int i = 0; i < Count - 3; i++)
            {
                FibNums.Add(FibNums[FibNums.Count - 1] + FibNums[FibNums.Count - 2]);
            }
            Console.WriteLine( FibNums[FibNums.Count - 1]);
        }
    }
}
