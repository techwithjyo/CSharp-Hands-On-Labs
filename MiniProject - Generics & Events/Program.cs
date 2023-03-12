using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace MiniProject___Generics___Events
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<PersonModel> people = new List<PersonModel>
            {
                new PersonModel{FirstName="Joe", LastName="M", Email="test1@gmail.com"},
                new PersonModel{FirstName="Johnnoob", LastName="Doe", Email="john@gmail.com"},
                new PersonModel{FirstName="Lucifer", LastName="Morningstar", Email="lucifer@welcometohell.com"}
            };

            List<CarModel> cars = new List<CarModel>
            {
                new CarModel{Manufacturer ="Toyota", Model="xyz"},
                new CarModel{Manufacturer ="Toyota", Model="Corolla"},
                new CarModel{Manufacturer ="Ford", Model="Mustang"}
            };

            var path = ".";
            var fullPath = Path.GetFullPath(path);

            people.SaveToCSV(@"C:\Test\people.csv");
            cars.SaveToCSV(@"C:\Test\cars.csv");

            Console.ReadLine();
        }
    }
    public static class DataAccess
    {
        //public static event EventHandler<Task>
        public static void SaveToCSV<T>(this List<T> items, string filePath) where T : new()
        {
            List<string> rows = new List<string>();
            T entry = new T();
            var cols = entry.GetType().GetProperties();

            string row = "";
            foreach (var col in cols)
            {
                row += $",{col.Name}";
            }
            row = row.Substring(1);
            rows.Add(row);

            foreach (var item in items)
            {
                row = "";

                bool badWordDetected = false;

                foreach (var col in cols)
                {
                    string val = col.GetValue(item, null).ToString();

                    badWordDetected = BadWordDetector(val);

                    if (badWordDetected == true)
                    {
                        break;
                    }

                    //row += $",{col.GetValue(item, null)}";
                    row += $",{val}";
                }
                if(badWordDetected == false)
                {
                    row = row.Substring(1);
                    rows.Add(row);
                }

            }
            File.WriteAllLines(filePath, rows);
        }
        private static bool BadWordDetector(string stringToTest)
        {
            bool output = false;
            string lowerCaseTest = stringToTest.ToLower();

            if (lowerCaseTest.Contains("noob"))
            {
                output = true;
            }
            return output;
        }
    }
}
