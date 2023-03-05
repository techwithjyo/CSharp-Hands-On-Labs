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
            //List<string> stringList = new List<string>();

            //string result = FizzBuzz("tests", 5, 5.35);

            //Console.WriteLine(result);

            //result = FizzBuzz(new PersonModel { FirstName = "Jyo", LastName = "M" }, 5, 5.35);

            //Console.WriteLine(result);

            GenericHelper<PersonModel> peopleHelper = new GenericHelper<PersonModel>();
            peopleHelper.CheckItemAndAdd(new PersonModel { FirstName = "Iron", LastName = "Man", HasError = true });

            foreach (var item in peopleHelper.RejectedItems)
            {
                Console.WriteLine(item.FirstName+ " " + item.LastName + " was rejected..");
            }

            Console.WriteLine(ConvertToStringAndPrint("random"));

            Console.WriteLine(ConvertToStringAndPrint(true));

            Console.WriteLine(ConvertToStringAndPrint(450));

            Console.WriteLine(ConvertToStringAndPrint(1.369));

            Console.WriteLine(ConvertToStringAndPrint('A'));

            Console.ReadKey();
        }
        private static string ConvertToStringAndPrint<T>(T item)
        {
            string output = item.ToString();

            return output;
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
    public class GenericHelper<T> where T: IErrorCheck, new()
        //Class Level Generic Declaration
    {
        public List<T> Items { get; set; } = new List<T>();
        public List<T> RejectedItems { get; set; } = new List<T>();

        public void CheckItemAndAdd(T item)
        {
            if(item.HasError == false)
            { 
                Items.Add(item); 
            }
            else
            {
                RejectedItems.Add(item);
            }
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
        public bool HasError { get ; set; }
    }
    public class PersonModel : IErrorCheck
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool HasError { get ; set ; }
    }
}
