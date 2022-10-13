using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Drawing;

namespace LearnCSharp
{
    class Program
    {
        static int staticFiled = 23;
        public enum Color { Red, Green, Blue, yellow, purple }
        static void Main(string[] args)
        {
            ConcatenationofConsecutiveBinaryNumbers binClass = new ConcatenationofConsecutiveBinaryNumbers();
            //binClass.ConcatenationofBinaryNumbers(12);
            StringBuilder sb = new StringBuilder();
                sb.Append(binClass.PaddingRight("5"));
            sb.Append(binClass.PaddingRight("xxxx"));
            sb.Append(binClass.PaddingRight(""));
            sb.Append(binClass.PaddingRight("__"));
            sb.Append(binClass.PaddingRight("abcd"));

            Console.WriteLine(sb.ToString());

            Console.ReadLine();

            //JsonParser parser = new JsonParser();
            //parser.parseJsonArray();
            return;

            //Solution.ReadInput();
            //return;

            //ArraysPractice.ArrayGetUpperBound();
            //return;
            //Console.WriteLine($"static field value: {staticFiled}");
            //var readStr = Console.ReadLine();

            //while (readStr.ToUpper() != "STOP")
            //{
            //    if (readStr.ToUpper() != "RUN")
            //        continue;
            //    GetColor();
            //    readStr = Console.ReadLine();
            //}

            //SerializationDemo.CallSerializeFunc();
            //return;

            AsynchrousProgram AP = new AsynchrousProgram();
            AP.callMethod();
            AP.Method2();
            //String S1 = "fafdas afadsf afdsfa afsdfdssgfgf gfdg";
            //S1.GetWordCount(' ');
            //Console.WriteLine(S1.GetWordCount(' ').ToString());
            //Collections.SampleArrayList();
            Console.WriteLine("apple".ReverseString());
            ExtensionMethods.SimpleMath();
            Console.ReadKey();

            Practice p = new Practice();
            Console.WriteLine(p.InstanceMethod());
            string[] Arr =  { "acbd", "afds" };
            Practice.FindCollection(Arr);
            List<int> li = new List<int> { 4, 5, 6, 8 };
            Practice.FindCollection(li);

            IEnumerable<int> a = from i in li
                                    where i % 2 == 0
                                    select i;

            Practice.FindCollection(a);

            int x = 1;
            Practice.ByVal(x);
            Console.WriteLine($"value of x after method call ByVal: {x} ");


            Practice.ByRef(ref x);
            Console.WriteLine($"value of x after method call ByRef: {x} ");

            var s = new LambdaExpressions();
            s.TestLambdaExpr();

            var alg = new Algorithms();
            alg.FindGcd(205, 25);
            alg.FindFibanucciNumber(21);
            Console.ReadLine();

        }

        static void GetColor()
        {
            Color c = (Color)(new Random()).Next(0, 5);
            switch (c)
            {
                case Color.Red:
                    Console.WriteLine("The color is red");
                    break;
                case Color.Green:
                    Console.WriteLine("The color is green");
                    break;
                case Color.Blue:
                    Console.WriteLine("The color is blue");
                    break;
                case Color.yellow:
                    Console.WriteLine("The color is yellow");
                    break;
                case Color.purple:
                    Console.WriteLine("The color is purple");
                    break;
                default:
                    Console.WriteLine("The color is unknown.");
                    break;
            }
        }
    }

    public class Practice
    {
        public static void FindCollection(object coll)
        {
            switch (coll)
            {
                case Array arr:
                    Console.WriteLine($"an array with length {arr.Length}");
                    break;
                case IList<int> list:
                    Console.WriteLine($"{list.Count} items");
                    break;
                case IEnumerable<int> ie:
                    Console.WriteLine($"{ie.Count()} enum items");
                    break;
                default:
                    break;
            }
        }

        public static void ByVal(int i)
        {
            i = 5;

        }

        public static void ByRef(ref int i)
        {
            i = 5;
        }
        // non-static method
        public string InstanceMethod()
        {
            return "non-static method";
        }
    }
}
