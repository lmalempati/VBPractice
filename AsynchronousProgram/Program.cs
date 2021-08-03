using System;
using System.Threading.Tasks;

namespace AsynchronousProgram
{
    // Async await. Asynchronous programming example.
    // Main thread does not wait for Method1 to complete, instead it continued to run Method2.
    class Program
    {
        static void Main(string[] args)
        {
            CallMethod1();
            Method2();
            Console.ReadKey();
        }

        public async static void CallMethod1()
        {
            await Method1();

        }

        public static async Task Method1()
        {
            await Task.Run(() =>
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine(" Method 1");
                    // Do something
                    Task.Delay(100).Wait();
                }
            });
        }


        public static void Method2()
        {
            //for (int i = 0; i < 25; i++)
            //{
            //    Console.WriteLine(" Method 2");
            //    // Do something
            //    Task.Delay(100).Wait();
            //}

            Task.Run(MyAction);
        }

        static Action MyAction = delegate() // an inline delegate
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine(" Method 2");
                    // Do something
                    Task.Delay(100).Wait();
                }
            };
    }
}
