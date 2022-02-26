using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp__Collections
{
    class Generics1
    {
        public bool CompareInt(int a , int b)
        {
            if (a == b)
                return true;
            return false;
        }

        public bool CompareFloat(float a, float b)
        {
            if (a == b)
                return true;
            return false;
        }
        public bool CompareNonTypeSafe(object a, object b)
        {
            if (a.Equals(b))
                return true;
            return false;
        }
        public bool CompareTypeSafe<T>(T a, T b)
        {
            if (a.Equals(b))
                return true;
            return false;
        }

    }
}
