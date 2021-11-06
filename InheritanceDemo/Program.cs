using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            SmartPhone smartPhone = new SmartPhone();
            LandLine landLine = new LandLine();

            landLine.PlaceCall();

            Phone phone = new SmartPhone();

            List<Phone> phones = new List<Phone>();
            phones.Add(new CellPhone());
            phones.Add(new SmartPhone());
            phones.Add(new Hotspot());

            foreach(var phn in phones)
            {
                if(phone is CellPhone cell)
                {
                    cell.Carrier = "";
                }
                if(phone is SmartPhone smrtphn)
                {
                    smrtphn.ConnectToInternet();

                }
            }

            Console.ReadLine();
        }
    }
}
