using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Class_Demo
{
    //Example 1
    //Abstract class is a half defined base class/parent class
    //Interface (Planning Abstractions) -> Abstract Class (Common Logic) -> Concrete Class (Fully implemented class)
    //Interfaces are implemented, where Abstract classes are inherited.
    public abstract class Vehicle
    {
        public string MadeBy { get; set; }
        public string Model { get; set; }
        public int ManufacturedYear { get; set; }
    }

    public class Car : Vehicle
    {
        public int NumberOfWheels { get; set; }
    }
    //Example 2
    public interface IActivity
    {
        void PerformActivity();
    }
    public abstract class ActivityBase : IActivity
    {
        public abstract void PerformActivity();
    }
    public class RunningActivity : ActivityBase
    {
        public override void PerformActivity()
        {
            Console.WriteLine("Running activity performed.");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //Example 1
            Car car= new Car();
            car.Model = "test";


            //Vehicle abstract class can't be instantiated, It's like a contract but the car class would have all the properties in it
            //Vehicle vehicle = new Vehicle();

            //Example 2
            IActivity activity = new RunningActivity();
            activity.PerformActivity();



            Console.ReadKey();
        }
    }
}
