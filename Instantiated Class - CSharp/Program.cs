using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Instantiated_Class___CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<PersonModel> listPersonModel = new List<PersonModel>();

            //PersonModel test = new PersonModel();

            //test.firstName = "Jyotirmoy";
            //test.lastName = "Maschatak";

            //listPersonModel.Add(test);

            //listPersonModel.Add(new PersonModel { firstName = "John", lastName = "Cena" });

            //foreach(PersonModel p in listPersonModel)
            //{
            //    Console.WriteLine(p.firstName + " " + p.lastName);
            //}

            List<PersonModel> people = new List<PersonModel>();
            string firstName = "";
            string lastName = "";

            do
            {
                Console.WriteLine("What is your firstName (or type exit to break the loop): ");
                firstName = Console.ReadLine();


                if (firstName.ToLower() != "exit")
                {
                    Console.WriteLine("What is your lastName ");
                    lastName = Console.ReadLine();
                    PersonModel p = new PersonModel();
                    p.FirstName = firstName;
                    p.LastName = lastName;
                    people.Add(p);
                }
            } while (firstName.ToLower() != "exit");

            foreach (PersonModel p in people)
            {
                Console.WriteLine($" {p.FirstName} {p.LastName} ");
                bool isGreeted = ProcessPerson.GreetPerson(p);
                if(isGreeted)
                    Console.WriteLine("Person greeted!");
            }


            Console.ReadLine();
        }
    }
}
