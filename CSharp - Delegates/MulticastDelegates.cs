using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp___Delegates
{
    
    class MulticastDelegates
    {
        //1. Declaration
        // Mulicast delegate: must have void return type
        public delegate void MyDelagate1(int a, int b); //delegates having the same signature as a method        
        public class Calculator1
        {
            // methods to be assigned and called by the delegate
            public void Add1(int a, int b)
            {
                int result = a + b;
                Console.WriteLine("Sum of two integer is = {0}", result);
            }

            public void Subtract1(int a, int b)
            {
                int result = a - b;
                Console.WriteLine("Subtraction of two integer is = {0}", result);
            }
        }
    }
}
