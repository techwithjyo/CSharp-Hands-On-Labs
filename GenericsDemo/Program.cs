using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CountWordLength("abc");
            CountWordLength(456);
            CountWordLength(125.25);
            CountWordLength(true);
            CountWordLength(new PersonModel { FirstName = "Joe", LastName = "M" });

            GenericHelper<PersonModel> genericHelper = new GenericHelper<PersonModel>();
            genericHelper.CheckItemAndAdd(new PersonModel { LastName = "M", FirstName = "Joe", HasError = false });
            genericHelper.CheckItemAndAdd(new PersonModel { LastName = "Smith", FirstName = "John", HasError = true });
            genericHelper.CheckItemAndAdd(new PersonModel { LastName = "Doe", FirstName = "Jane", HasError = false });
            genericHelper.CheckItemAndAdd(new PersonModel { LastName = "Brown", FirstName = "Charlie", HasError = true });
            genericHelper.CheckItemAndAdd(new PersonModel { LastName = "Johnson", FirstName = "Chris", HasError = false });
            genericHelper.CheckItemAndAdd(new PersonModel { LastName = "Williams", FirstName = "Pat", HasError = true });
            genericHelper.CheckItemAndAdd(new PersonModel { LastName = "Jones", FirstName = "Alex", HasError = false });
            genericHelper.CheckItemAndAdd(new PersonModel { LastName = "Garcia", FirstName = "Taylor", HasError = true });
            genericHelper.CheckItemAndAdd(new PersonModel { LastName = "Martinez", FirstName = "Jordan", HasError = false });
            genericHelper.CheckItemAndAdd(new PersonModel { LastName = "Davis", FirstName = "Morgan", HasError = true });
            genericHelper.CheckItemAndAdd(new PersonModel { LastName = "Rodriguez", FirstName = "Casey", HasError = false });
            Console.WriteLine();

            foreach (var item in genericHelper.items)
            {
                Console.WriteLine("Accepted Items: " + item.FirstName + " " + item.LastName + " .Error Flag:" + item.HasError);
            }
            Console.WriteLine();
            foreach (var item in genericHelper.rejectedItems)
            {
                Console.WriteLine("Rejected Items: " + item.FirstName + " " + item.LastName + " .Error Flag:" + item.HasError);
            }

            Console.ReadLine();
        }

        public static void CountWordLength<T>(T item)
        {
            var oldItemType = item.GetType();
            var data = item.ToString();
            Console.WriteLine($"Data: {data}, OldType: {oldItemType}, Length: {data.Length}");
        }

        public class GenericHelper<T> where T : IErrorCheck
        {
            public List<T> items = new List<T>();
            public List<T> rejectedItems = new List<T>();

            public void CheckItemAndAdd(T item)
            {
                if (item.HasError)
                {
                    rejectedItems.Add(item);
                }
                else
                    items.Add(item);
            }
        }
        public interface IErrorCheck
        {
            bool HasError { get; set; }
        }
        class PersonModel : IErrorCheck
        {
            public string LastName { get; set; }
            public string FirstName { get; set; }
            public bool HasError { get; set; }
        }

    }
}
