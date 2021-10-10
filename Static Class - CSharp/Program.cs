using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Class___CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            SayHello();  //Technically it is Program.Hello();

            string firstName = RequestDataClass.GetAString("What is you firstName ? ");

            UserMessages.ApplicationStartMessageForUser(firstName); //Class Name first, Then method name!

            double x = RequestDataClass.GetTheDouble("Please enter you first number - ");

            double y = RequestDataClass.GetTheDouble("Please enter your second number - ");

            double result = CalculateData.Add(x, y);

            UserMessages.PrintResultMessage("The sum of " + x + " & " + y + " is " + result);

            Console.ReadLine();

        }

        private static void SayHello()
        {
            Console.WriteLine("Hello!!");
        }
    }
}
