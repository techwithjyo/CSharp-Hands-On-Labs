using System;

namespace CSharp_Extension_Method_Demo_App
{
    public class SimpleLogger : ISimpleLogger
    {
        public void Log(String message)
        {
            Console.WriteLine(message);
        }

        public void Log(string message, string messageType)
        {
            Log($"{messageType}: {message}");
        }
    }
}
