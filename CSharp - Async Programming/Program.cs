using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSharp___Async_Programming
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-- ASync Method Call");
            var result1 = MyMethodAsync(100); // no wait

            Console.WriteLine("-- Sync Method Call");
            var result2 = MyMethodSync(100); //wait

            Console.WriteLine("ASync Method Call Result - " + result1.Result);
            Console.WriteLine("Sync Method Call Result - "+result2);

            Console.ReadLine();
        }

        private static int MyMethodSync(int count)
        {
            int result = 0;
            for(int i=1 ; i<count ; i++)
            {
                Thread.Sleep(500);
                Console.WriteLine("Sync number print - "+ i);
                result += i; 
            }
            return result;
        }
        private static Task<int> MyMethodAsync(int count)
        {
            Task<int> task = new Task<int>(() =>
            {
                int result = 0;
                for (int i = 1; i < count; i++)
                {
                    Thread.Sleep(500);
                    Console.WriteLine("ASync number print - " + i);
                    result += i;
                }
                return result;
            }
            );
            task.Start();
            return task;
        }
    }
}
