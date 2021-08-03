using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCSharp
{
    public delegate int DelAdd(int i, int j);

    public class LambdaExpressions
    {
        DelAdd F1, F2;
        public int Add(int i, int j)
        {
            return i + j;
        }

    public void TestLambdaExpr()
        {
            // Declare a Func variable and assign a lambda expression to the
            // variable. The method takes a string and converts it to uppercase.
            Func<string, string> selector = str => str.ToUpper();
            Func<string, bool> boolselctor = str => str.Length % 2 == 0;
            Func<string, string> sameselctor = str => str;

            // Create an array of strings.
            Array a;
            string[] words = { "orange", "apple", "Article", "elephant" };
            var li = new List<string> { "orange", "apple", "Article", "elephant" };
            li.Sort();
            // Query the array and select strings according to the selector method.
            IEnumerable<String> aWords = words.Select(selector);
            IEnumerable<String> boolWords = words.Where(boolselctor);


            IEnumerable<Boolean> aWordlengths = words.Select(boolselctor);

            // Output the results to the console.
            foreach (String word in aWords)
                Console.WriteLine(word);

            /*
            This code example produces the following output:

            ORANGE
            APPLE
            ARTICLE
            ELEPHANT

            */
            // Output the results to the console.
            foreach (Boolean word in aWordlengths)
                Console.WriteLine(word);

            Console.WriteLine("List enumerator");
            IEnumerable<String> liWords = li.Where(boolselctor).Select(str => str.ToUpper());
            foreach (string word in liWords)
                Console.WriteLine(word);

        }
    }

}
