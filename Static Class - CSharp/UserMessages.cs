using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Class___CSharp
{
    public class UserMessages
    {
        public static void ApplicationStartMessageForUser(string firstName)
        {
            Console.Clear();
            Console.WriteLine("Welcome to the App " + firstName +"!!");

            int hourOfTheDay = DateTime.Now.Hour;

            if(hourOfTheDay < 12)
                Console.WriteLine("Good Morning Gentleman!!");
            else if (hourOfTheDay < 19)
                Console.WriteLine("Good Afternoon Gentleman!!");
            else
                Console.WriteLine("Good Evening Gentleman!!");
        }

        public static void PrintResultMessage(string message)
        {
            Console.WriteLine(message);
            Console.WriteLine();
            Console.WriteLine("Thank you for using our app to calculate for you!!");
        }
    }

    
}
