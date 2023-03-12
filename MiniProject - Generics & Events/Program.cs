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

            DataAccess<PersonModel> peopleData = new DataAccess<PersonModel>();
            peopleData.BadEntryFound += PeopleData_BadEntryFound;
            DataAccess<CarModel> carData = new DataAccess<CarModel>();
            carData.BadEntryFound += CarData_BadEntryFound;

            peopleData.SaveToCSV(people,@"C:\Test\people.csv");
            carData.SaveToCSV(cars,@"C:\Test\cars.csv");

            Console.ReadLine();
        }

        private static void CarData_BadEntryFound(object sender, CarModel e)
        {
            Console.WriteLine($"Bad entry found for {e.Manufacturer} {e.Model}");
        }

        private static void PeopleData_BadEntryFound(object sender, PersonModel e)
        {
            Console.WriteLine($"Bad entry found for {e.FirstName} {e.LastName}");
        }
    }
    public class DataAccess<T> where T: new()
    {
        public event EventHandler<T> BadEntryFound;
        public void SaveToCSV(List<T> items, string filePath)
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
                        BadEntryFound?.Invoke(this, item);
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
        private bool BadWordDetector(string stringToTest)
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
