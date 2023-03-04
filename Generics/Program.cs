using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> stringList = new List<string>();

            string result = FizzBuzz("tests", 5, 5.35);

            Console.WriteLine(result);

            result = FizzBuzz(new PersonModel { FirstName = "Jyo", LastName = "M" }, 5, 5.35);

            Console.WriteLine(result);

            Console.ReadKey();
        }

        private static string FizzBuzz<T, U, V>(T item, U extraItem, V extraExtraItem)
        {
            int itemLength = item.ToString().Length;
            string output = "";

            if (itemLength % 3 == 0)
            {
                output += "Fizz";
            }

            if (itemLength % 5 == 0)
            {
                output += "Buzz";
            }

            return output;
        }
    }
    public class GenericHelper<T> where T: class, IErrorCheck
        //Class Level Generic Declaration
    {
        public List<T> Items { get; set; }
        public List<T> RejectedItems { get; set; }

        public void CheckItemAndAdd(T item)
        {
            Items.Add(item);
        }
    }
    public interface IErrorCheck
    {
        bool HasError { get; set; }
    }
    public class CarModel : IErrorCheck
    {
        public string Manufacturer { get; set; }
        public int YearManufactures { get; set; }
        public bool HasError { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
    public class PersonModel : IErrorCheck
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool HasError { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
