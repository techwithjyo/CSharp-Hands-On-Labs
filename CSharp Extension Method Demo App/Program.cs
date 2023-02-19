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

            ISimpleLogger logger = new SimpleLogger();
            logger.Log("Test Error", "Error");
            logger.LogError("This is an Error!!");
            logger.LogWarning("This is a Warning!!");

            Console.ReadLine();
        }
    }
}
