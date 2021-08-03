using System;
using System.Threading.Tasks;

namespace AsynchronousProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            TestAsyncAwaitMethods();
            Console.WriteLine("Press any key to exit...");
            Console.ReadLine();
        }

        public async static void TestAsyncAwaitMethods()
        {
            await LongRunningMethod();
        }

        // Task.Delay makes method to run asynchronously but thread.sleep can't
        public async static Task<int> LongRunningMethod()
        {
            Console.WriteLine("Starting Long Running method...");
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("in Long Running method...");
                await Task.Delay(1000);
                //System.Threading.Thread.Sleep(1000);

            }
            Console.WriteLine("End Long Running method...");
            return 1;
        }
    }
}
