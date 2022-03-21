using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp___Partial_Class
{
    partial class Calculator1
    {
        partial void PartialAdd(int x, int y); //declaration
    }
    partial class Calculator1
    {
        public void Add(int x, int y)
        {
            PartialAdd(x, y);
        }

        partial void PartialAdd(int x, int y) //implementation
        {
            int sum = x + y;
            Console.WriteLine("Sum of {0} and {1} is : {2}", x, y, sum);
        }
    }
    class PartialMethods
    {
        //Change entry point while running
        static void Main(string[] args)
        {
            int num1 = 4, num2 = 2;

            Calculator calc = new Calculator();
            calc.Add(num1, num2);
        }
    }
}
