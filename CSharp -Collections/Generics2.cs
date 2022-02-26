using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp__Collections
{
    class Generics2
    {
        public void Add1<T>(T a , T b)
        {
            dynamic a1 = a;
            dynamic b1 = b;
            Console.WriteLine(a1 + b1);
        }
        
    }
    class Generics3<T>
    {
        public void Add1(T a, T b)
        {
            dynamic a1 = a;
            dynamic b1 = b;
            Console.WriteLine(a1 + b1);
        }
    }
}
