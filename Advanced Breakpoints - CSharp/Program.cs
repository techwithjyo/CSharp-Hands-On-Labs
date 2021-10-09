using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_Breakpoints___CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            TestMethod();
            Console.ReadLine();
        }

        public static void TestMethod()
        {
            long total = 0;
            int test = 0;

            for (int i = -1000; i <= 1000; i++)
            {
                //Right click and click on conditions on VS, Then you can set the condition for the breakpoint.
                total += i;

                try
                {
                    test = 5 / i;
                }
                catch (Exception)
                {
                    Console.WriteLine("There was some exception.");
                }


            }
            Console.WriteLine(total);
        }
    }
}
