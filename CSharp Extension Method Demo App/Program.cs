using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using ExtensionSamplesDemo.Extensions;

namespace CSharp_Extension_Method_Demo_App
{
    public class Program
    {
        static void Main(string[] args)
        {
            HotelRoomModel room = new HotelRoomModel();

            room.TurnOnAir().SetTemperature(52).OpenShades();

            room.TurnOffAir().CloseShades();

            "Hello World".PrintToConsole();

            SimpleLogger logger = new SimpleLogger();
            logger.Log("Test Error", "Error");
            logger.LogError("This is an Error!!");
            logger.LogWarning("This is a Warning!!");

            Console.ReadLine();
        }
    }
    public class HotelRoomModel
    {
        public int Temperature { get; set; }
        public bool IsAirRunning { get; set; }
        public bool AreShadesOpen { get; set; }
    }

    public static class ExtendSimpleLogger
    {
        public static void LogError(this SimpleLogger logger, string message)
        {
            var defualtColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Red;
            logger.Log(message, "Error");
            Console.ForegroundColor = defualtColor;
        }
        public static void LogWarning(this SimpleLogger logger, string message)
        {
            var defualtColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Yellow;
            logger.Log(message, "Warning");
            Console.ForegroundColor = defualtColor;
        }
    }
    public class SimpleLogger
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
