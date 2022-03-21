using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp___Properties_Dotnettricks
{
    class User
    {
        public string publicProperty;
        private string firstname;
        
        public string FirstName
        { //full implementation
            get
            {
                return firstname;
            }
            set
            {
                firstname = value;
            }
        }
        public string LastName { get; set; } //short implementation

        public string FullName
        {
            //set is blocked, that means it is a readonly property
            get
            {
                return firstname +" "+ LastName;
            }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            User usr = new User();
            usr.publicProperty = "Public Property";

            usr.FirstName = "Jyotirmoy";

            usr.LastName = "Maschatak";

            //usr.FullName = "dasd";

            Console.WriteLine("Public Property- "+usr.publicProperty + " //Declared Property- "+ usr.FirstName+" //LastName- "+usr.LastName);
            Console.WriteLine("Full Name Private Property without Set - "+usr.FullName);
            Console.ReadLine();
        }
    }
}
