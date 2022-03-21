using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp___Partial_Class
{
    // Partial Class Part1
    partial class Calculator
    {
        public int Add(int x, int y)
        {
            return x + y;
        }
    }

    // Partial Class Part2
    partial class Calculator
    {
        public int Subtract(int x, int y)
        {
            return x - y;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 4, num2 = 2;
            Calculator calc = new Calculator();

            int sum = calc.Add(num1, num2);
            Console.WriteLine("Sum of {0} and {1} is : {2}", num1, num2, sum);

            int subtract = calc.Subtract(num1, num2);
            Console.WriteLine("Subtraction of {0} and {1} is : {2}", num1, num2, subtract);

            Console.ReadLine();
        }
    }
}
