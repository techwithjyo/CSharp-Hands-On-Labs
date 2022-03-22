using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CSharp___Delegates.MulticastDelegates;

namespace CSharp___Delegates
{
    //1. Declaration
    // Singlecast delegate
    public delegate int MyDelagate(int a, int b); //delegates having the same signature as a method        
    public class Calculator
    {
        // methods to be assigned and called by the delegate
        public int Add(int a, int b)
        {
            Console.WriteLine("Add Method is called!");
            return a + b;
        }

        public int Subtract(int a, int b)
        {
            Console.WriteLine("Subtract Method is called!");
            return a - b;
        }
    }

    class SingleCastDelegates
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();

            // 2. Instantiation : As a singlecast delegate
            MyDelagate sum = new MyDelagate(calc.Add);
            MyDelagate diff = new MyDelagate(calc.Subtract);

            // 3.Invocation
            Console.WriteLine("Sum of two integer is = {0}", sum(10, 20));
            Console.WriteLine("Subtraction of two integer is = {0}", diff(20, 10));



            //////---------------Multicast Delegates------------------------
            ///
            //Check the other CS file for better example of multicast delegates.
            Calculator1 calc1 = new Calculator1();
            MyDelagate1 multicast = new MyDelagate1(calc1.Add1);
            multicast += new MyDelagate1(calc1.Subtract1);
            multicast(2, 3);

            Console.ReadKey();
        }
    }
}
