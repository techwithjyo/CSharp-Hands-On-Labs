using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp___Anonymous_Method_and_Lambda_Expression
{
    class Program
    {
        //delegate
        delegate int del(int x, int y);

        static void Main(string[] args)
        {
            //anonymous method
            del d1 = delegate (int x, int y) { return x * y; };
            int result1 = d1(2, 3);
            Console.WriteLine(result1);

            //expression lambda
            del d2 = (x, y) => x * y;
            int result2 = d2(3, 3);
            Console.WriteLine(result2);

            //statement lambda
            del d3 = (x, y) => { return x * y; };
            int result3 = d2(4, 3);
            Console.WriteLine(result3);
            Console.ReadLine();
        }
    }
}
