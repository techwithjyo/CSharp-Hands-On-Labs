using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Class___CSharp
{
    static class RequestDataClass
    {

        public static double GetTheDouble(string message)
        {
            Console.WriteLine(message);
            double theNumberInDoubleFormat;
            string numberText = Console.ReadLine();

            bool isParseSuccessful = double.TryParse(numberText, out theNumberInDoubleFormat);

            while (!isParseSuccessful)
            {
                Console.WriteLine("That was not a valid number Gentleman! Please enter it properly- ");
                Console.WriteLine(message);
                numberText = Console.ReadLine();

                isParseSuccessful = double.TryParse(numberText, out theNumberInDoubleFormat);
            }

            return theNumberInDoubleFormat;

        }

        public static string GetAString(string message)
        {
            Console.WriteLine(message);
            string output = Console.ReadLine();
            return output;
        }
    }
}
