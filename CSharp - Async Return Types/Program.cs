using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSharp___Async_Return_Types
{
    class Program
    {
        static void Main(string[] args)
        {
            var result1 = MethodAsync1(5);
            result1.Wait(); //aggregate exception : exception hidden with in innerexception
            result1.GetAwaiter().GetResult(); //argument exception : detailed explanation

            var result2 = MethodAsync2(5);
            result2.Wait();
            Console.WriteLine("After Text");
            Console.ReadLine();
        }

        private static Task MethodAsync1(int count)
        {
            Task task = new Task(() =>
            {
                for (int i = 1; i <= count; i++)
                {
                    Thread.Sleep(200);
                    Console.WriteLine("Async Number: " + i);
                }
            });
            task.Start();
            return task;
        }
        private static Task<int> MethodAsync2(int count)
        {
            int result = 0;
            Task<int> task = new Task<int>(() =>
            {
                for (int i = 1; i <= count; i++)
                {
                    Thread.Sleep(200);
                    Console.WriteLine("Async Number: " + i);
                    result += i ;
                }
                return result;
            });
            task.Start();
            return task;
        }

        private static void PrintAsync(string message)
        {
            Task task = new Task(() =>
            {
                Console.WriteLine(message);
            });
            task.Start();
        }
    }
}
