using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp___Tuple
{
    class Program
    {
        public static void Main()
        {
            //var person = new Tuple<int, string, string>(1, "Mohan", "Kumar");

            //OR
            var person = Tuple.Create(1, "Mohan", "Kumar");
            ShowData(person);
        }
        static void ShowData(Tuple<int, string, string> person)
        {
            Console.WriteLine("Id: {0}", person.Item1);
            Console.WriteLine("First Name : {0}", person.Item2);
            Console.WriteLine("Last Name : {0}", person.Item3);
        }

    }
}
