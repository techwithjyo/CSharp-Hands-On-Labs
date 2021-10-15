using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Instantiated_Class___CSharp
{
    public static class ProcessPerson
    {
        public static bool GreetPerson(PersonModel p)
        {
            Console.WriteLine($"Welcome  {p.FirstName} {p.LastName} ");
            p.IsGreeted = true;

            return p.IsGreeted;
        }
    }
}
