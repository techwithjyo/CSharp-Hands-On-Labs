using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp__Collections
{
    class Employee
    {
        public int TechMansID { get; set; }
        public string TechMansName { get; set; }
        public string TechMansCountry { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            Console.WriteLine(arr.Length);
            Array.Resize(ref arr, 15);
            Console.WriteLine(arr.Length);

            ArrayList arraylist = new ArrayList();
            arraylist.Add(10);
            arraylist.Add(20);
            arraylist.Add(30);
            arraylist.Add(40);
            arraylist.Add(50);

            foreach(var a in arraylist)
            {
                Console.WriteLine(a);
            }

            Console.WriteLine("--------------------Hash Table----------------");

            Hashtable hashtable = new Hashtable();
            hashtable.Add("EmployeeId", 1010);
            hashtable.Add("Name", "Jyotirmoy");
            hashtable.Add("Country", "India");
            hashtable.Add("Designation", "Developer");
            hashtable.Add("YearOfJoining", 2022);

            Console.WriteLine(hashtable["Name"]);

            foreach(object key in hashtable.Keys)
            {
                Console.WriteLine(key + " : " +hashtable[key]);
            }
            foreach (object values in hashtable.Values)
            {
                Console.WriteLine(values);
            }

            Console.WriteLine("--------Generic Collections--------");

            List<int> li = new List<int>();
            li.Add(10);
            li.Add(20);

            List<Employee> employees = new List<Employee>();
            Employee employee = new Employee();
            employee.TechMansID = 10;
            employee.TechMansName = "Jyotirmoy";
            employee.TechMansCountry = "India";

            employees.Add(employee);

            Console.WriteLine("-------------Why We need Generics------------Pain points ");
            Generics1 generics1 = new Generics1();
            bool result = generics1.CompareInt(10, 10);
            Console.WriteLine(result);
            result = generics1.CompareFloat(10.01f,10.99f);
            Console.WriteLine(result);
            result = generics1.CompareNonTypeSafe(10.01f, 10.99f);
            Console.WriteLine(result);

            Console.WriteLine("------------Type Safe Methods -  Genreric Methods--------------");
            result = generics1.CompareTypeSafe<int>(10, 10);
            Console.WriteLine(result);
            result = generics1.CompareTypeSafe<float>(10.2f, 109.0f);
            Console.WriteLine(result);
            result = generics1.CompareTypeSafe<double>(4.5, 5.6);
            Console.WriteLine(result);

            Console.WriteLine("----------Generic Class------------- ");
            Generics2 generics2 = new Generics2();
            generics2.Add1<int>(10, 20); //Generic Methods
            generics2.Add1<float>(10.5f, 20.5f);
            generics2.Add1<double>(10.1, 10.1);

            Generics3<int> generics3AddInt = new Generics3<int>();
            generics3AddInt.Add1(10, 20);

            Generics3<float> generics3AddFloat = new Generics3<float>();
            generics3AddFloat.Add1(10.2f, 10.6f);

            Console.ReadLine();
        }
    }
}
