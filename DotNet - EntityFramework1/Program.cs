using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet___EntityFramework1
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerEntities objContext = new CustomerEntities();

            //Reading
            List<tblCountry> objCountries = objContext.tblCountries.ToList<tblCountry>();
            
            foreach(tblCountry t in objCountries)
            {
                Console.WriteLine(t.countryID + " " + t.countryName+ " "+ t.Population);
            }

            //Insert
            tblCountry objCountry1 = new tblCountry();
            objCountry1.countryName = "Amazon";
            objCountry1.Population = "999";
            objContext.tblCountries.Add(objCountry1);
            objContext.SaveChanges();

            //Updating
            tblCountry objCountry2 = objCountries[0];
            objCountry2.countryName = "UpdatedCountry";
            objCountry2.Population = "1010";
            objContext.SaveChanges();

            //Delete
            objContext.tblCountries.Remove(objCountry2);
            objContext.SaveChanges();

            Console.ReadLine();
        }
    }
}
