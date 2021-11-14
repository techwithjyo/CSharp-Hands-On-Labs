using OOP2___AccessModifiersDemo___Class_Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2___AccessModifiersDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();

            DataAccess da = new DataAccess();

            //da.GetConnectionString();

            person.SavePerson();

            Console.ReadLine();
        }
    }
}
