using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo
{
    //Interface is a contract
    // Classes implement interfaces
    class Program
    {
        static void Main(string[] args)
        {
            List<IComputerController> controllers = new List<IComputerController>();

            Keyboard keyboard = new Keyboard();
            GameController gameController = new GameController();
            BatteryPoweredGameController batteryGameController = new BatteryPoweredGameController();
            BatteryPoweredKeyboard batteryKeyboard = new BatteryPoweredKeyboard();

            controllers.Add(keyboard);
            controllers.Add(gameController);
            controllers.Add(batteryGameController);


            foreach (IComputerController controller in controllers)
            {

            }

            using (GameController gc = new GameController())
            {

            }

            List<IBatteryPowered> powereds = new List<IBatteryPowered>();

            powereds.Add(batteryGameController);
            powereds.Add(batteryKeyboard);

            Console.ReadLine();
        }
    }
    public interface IComputerController
    {
        void Connect();
        void CurrentKeyPressed();
    }

    public class Keyboard : IComputerController
    {
        public void Connect()
        {

        }

        public void CurrentKeyPressed()
        {

        }
        public string ConnectionType { get; set; }
    }
    public class GameController : IComputerController, IDisposable
    {
        public void Connect()
        {
            throw new NotImplementedException();
        }

        public void CurrentKeyPressed()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            //do whatever shutdown task needed
        }

        public int BatteryLevel { get; set; }

    }
    public interface IBatteryPowered
    {
         int BatteryLevel { get; set; }
    }
    public class BatteryPoweredKeyboard : Keyboard, IBatteryPowered
    {
        public int BatteryLevel { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
    public class BatteryPoweredGameController : GameController , IBatteryPowered
    {
        public int BatteryLevel { get; set; }
    }

}
