using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1___Properties___CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonModel person = new PersonModel();

            person.FirstName = "Jyotirmoy";
            person.LastName = "Maschatak";
            person.Age = 40;
            person.SSN = "123-45-6789";
            //person.FullName = "Jyotirmoy Maschatak"; //as the property modifier is private

            Console.WriteLine(person.SSN);

            Console.WriteLine(person.FullName);


            Console.ReadLine();
        }
    }
}
