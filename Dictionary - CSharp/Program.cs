using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary___CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> employeeDetails = new Dictionary<int, string>();

            employeeDetails[100] = "Jyotirmoy";
            employeeDetails[101] = "Ram";
            employeeDetails[102] = "Sid";
            employeeDetails[103] = "Arjun";

            Console.WriteLine("Please enter the user ID to fetch the user name, Please select the user ID which are in the below list: ");
            foreach(KeyValuePair<int , string> keyValue in employeeDetails)
            {
                Console.WriteLine(keyValue.Key);
            }

            Console.WriteLine("Please enter the user ID for which you want to fetch data for the user: ");
            string userIdInString = Console.ReadLine();
            bool userFound = false;

            foreach (KeyValuePair<int, string> keyValue in employeeDetails)
            {
                if(keyValue.Key == Int32.Parse(userIdInString))
                {
                    Console.WriteLine($"User Found, the name of the user for user ID { keyValue.Key } is: " + keyValue.Value);
                    userFound = true;
                    break;
                }

            }
            if (!userFound)
            {

                Console.WriteLine("Sorry, User not found!"); 
            }

            Console.ReadLine();
        }
    }
}
