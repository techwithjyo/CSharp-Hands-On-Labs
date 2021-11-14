using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2___AccessModifiersDemo___Class_Library
{
    public class DataAccess
    {
        protected internal string GetConnectionString()
        {
            return "Sensitive Data";
        }
    }
    public class Person
    {
        protected string formerLastName = "";
        public string FirstName { get; private set; }
        public string LastName { get; private set; }

        private string _ssn;

        public string SSN
        {
            get
            {
                return $"****-**-{_ssn.Substring(_ssn.Length - 4)}";
            }
            set { _ssn = value; }
        }

        public void ChangeLastName(string newLastName)
        {
            formerLastName = LastName;
            LastName = newLastName;
        }

        public void Hello()
        {
            string test = "Hi";
            Console.WriteLine($"Hello {FirstName}");
        }

        public void SavePerson()
        {
            DataAccess da = new DataAccess();
            string conn = da.GetConnectionString();
            //saves the person;
        }
    }

    public class Employee : Person
    {
        public string GetFormerLastName()
        {
            return formerLastName;
        }
    }

    public class Manager : Employee
    {
        public string GetAllNames()
        {
            return $"{FirstName} , { LastName}, {formerLastName}";
        }
    }
}
