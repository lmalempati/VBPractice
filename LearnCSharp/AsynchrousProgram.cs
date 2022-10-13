using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCSharp
{
    public class AsynchrousProgram
    {
        public  async Task<int> AsynMethod1()
        {
            var count = 0;

            Action a;
            a = Miscellaneous.Displaymsg;
            a = () =>
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("async method1: Action running...");
                    Task.Delay(100).Wait();
                    count++;
                }
            };
            //a.Invoke();

            //await Task.Run(a);

            await Task.Run(() =>
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("async method1 running...");
                    Task.Delay(100).Wait();
                    count++;
                }
            });
            return count;
        }

        public  void Method2()
        {
            for (int i = 0; i < 25; i++)
            {
                Console.WriteLine(" Method 2");
                // do something
                Task.Delay(100).Wait();
            }
        }

        public  void Method3(int count)
        {
            Console.WriteLine("Total count is " + count);
        }

        public  void Main()
        {
            //callMethod();
            //Console.ReadKey();
        }

        public async void callMethod()
        {
            var count = await AsynMethod1();

            Method3(count);
        }
    }

    class Miscellaneous
    {
        public static void Displaymsg()
        {
            Console.WriteLine("Hi there");
        }
    }
}
