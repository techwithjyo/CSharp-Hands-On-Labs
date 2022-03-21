using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp___Indexers
{
    class IndexerClass
    {
        private string[] cities = new string[10];

        public string this[int i]
        {
            get 
            {
                return cities[i];
            }
            set 
            {
                cities[i] = value;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            IndexerClass citiesObject = new IndexerClass();
            citiesObject[1] = "Kolkata";
            citiesObject[2] = "Hyderabad";
            citiesObject[3] = "Bangalore";
            citiesObject[4] = "Pune";
            citiesObject[5] = "Chennai";

            for(int i=0;i<10; i++)
            {
                Console.WriteLine(citiesObject[i]);
            }
            Console.ReadLine();
        }
    }
}
