using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp___Object_Type_Example
{
    class Utility
    {
        //accepting two types of parameter:integer and string
        //returning two types of result: integer and string
        public object Add(object param1, object param2)
        {
            if (param1 is int && param2 is int)
                //need typecasting to perform add operation
                return Convert.ToInt32(param1) + Convert.ToInt32(param2);

            else if (param1 is string && param2 is string)
                //need typecasting to perform string concat operation
                return Convert.ToString(param1) + " " + Convert.ToString(param2);

            else
                return "Parameters can be either integer values or string values";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Utility util = new Utility(); ;

            //string result
            object result1 = util.Add("Shailendra", "Chauhan");
            Console.WriteLine(result1);

            //integer result
            object result2 = util.Add(3, 2);
            if (result2 is int)
                Console.WriteLine("Sum of numbers is : {0}", result2);

            //string error message
            object result3 = util.Add("Hello", 0);
            Console.WriteLine(result3);
            Console.ReadLine();
        }
    }
}
