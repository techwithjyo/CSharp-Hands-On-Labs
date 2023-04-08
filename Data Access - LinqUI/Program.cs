using Data_Access___LinqUI.Models;
using System;
using System.Linq;

namespace Data_Access___LinqUI
{
    public class Program
    {
        static void Main(string[] args)
        {
            //LambdaTests();
            LinqTest();
            Console.WriteLine("Done Processing..");
            Console.ReadLine();
        }

        private static void LinqTest()
        {
            var contacts = SampleData.GetContactData();
            var addresses = SampleData.GetAddressData();

            //var result = (from c in contacts
            //                join a in addresses
            //                on c.Id equals a.ContactId
            //                where c.Addresses.Count > 1
            //                select new { c.FirstName, c.LastName, a.City, a.State});

            // foreach (var item in result)
            // {
            //     Console.WriteLine(item.FirstName + " " + item.LastName +" from "+ item.City + " , "+ item.State);
            // }

            var results = (from c in contacts
                           select new { c.FirstName, c.LastName , Addresses= addresses.Where(a => c.Addresses.Contains(a.Id))});
            foreach (var item in results)
            {
                Console.WriteLine(item.FirstName + " " + item.LastName + " with address count " + item.Addresses.Count());
            }
        }

        private static void LambdaTests()
        {
            var data = SampleData.GetContactData();

            //var result = data.Where(x => x.Addresses.Count > 1);
            //foreach(var item in result)
            //{
            //    Console.WriteLine(item.FirstName + " " + item.LastName);
            //}

            //var result = data.Select(x => x.LastName);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            //var result = data.Take(2);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item.FirstName + " " + item.LastName);
            //}

            //var result = data.Skip(2).Take(2);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item.Id+ " " + item.FirstName + " " + item.LastName);
            //}

            //var result = data.OrderBy(x => x.LastName);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item.Id + " " + item.FirstName + " " + item.LastName);
            //}

            var result = data.OrderByDescending(x => x.LastName);
            foreach (var item in result)
            {
                Console.WriteLine(item.Id + " " + item.FirstName + " " + item.LastName);
            }
        }

        private static bool RunMe(ContactModel x)
        {
            if (x.Addresses.Count > 1)
                return true;
            else
                return false;
        }
    }
}
