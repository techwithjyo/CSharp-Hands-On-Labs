using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProject___Inheritance___Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            List<InventoryItemModel> inventory = new List<InventoryItemModel>();
            List<IRentable> rentables = new List<IRentable>();
            List<IPurchaseable> purchaseables = new List<IPurchaseable>();

            var vehicle = new VehicleModel { DealerFee = 25, ProductName = "Jeep Compass" };
            var book = new BookModel { ProductName = "The rudest book ever!", NumberOfPages = 200 };
            var excavator = new ExcavatorModel { ProductName = "Premium Quality Excavator", QuantityInStock = 2 };

            rentables.Add(vehicle);
            rentables.Add(excavator);

            purchaseables.Add(book);
            purchaseables.Add(vehicle);

            //inventory.Add(new VehicleModel { DealerFee = 25, ProductName = "Jeep Compass" });
            //inventory.Add(new BookModel { ProductName = "The rudest book ever!", NumberOfPages = 200 });

            Console.Write("Do you want to purchase something? (rent, purchase) ");
            string decisionFromUser = Console.ReadLine();

            if(decisionFromUser.ToLower() == "rent")
            {
                foreach(var item in rentables)
                {
                    Console.WriteLine($"Item: {item.ProductName}");
                    Console.Write("Do you want to rent this item? (yes/no)");
                    string wantToRent = Console.ReadLine();
                    if(wantToRent.ToLower() == "yes")
                    {
                        item.Rent();
                    }

                    Console.Write("Do you want to return this item? (yes/no)");
                    string wantToReturn = Console.ReadLine();
                    if (wantToReturn.ToLower() == "yes")
                    {
                        item.ReturnRental();
                    }
                }
            }
            else
            {
                foreach(var item in purchaseables)
                {
                    Console.WriteLine($"Item: {item.ProductName}");
                    Console.Write("Do you want to purchase the product? (yes/no)");
                    string wantToPurchase = Console.ReadLine();

                    if(wantToPurchase.ToLower() == "yes")
                    {
                        item.Purchase();
                    }


                }
            }
            Console.WriteLine("You are done with Shopping!");

            Console.ReadLine();
        }
    }
    public interface IInventoryItem
    {
         string ProductName { get; set; }
         int QuantityInStock { get; set; }

    }
    public interface IRentable : IInventoryItem
    {
        void Rent();
        void ReturnRental();
    }
    public interface IPurchaseable :IInventoryItem
    {
        void Purchase();

    }

    public class InventoryItemModel : IInventoryItem
    {
        public string ProductName { get; set; }
        public int QuantityInStock { get; set; }
    }
    public class VehicleModel : InventoryItemModel, IPurchaseable, IRentable
    {
        public decimal DealerFee { get; set; }

        public void Purchase()
        {
            QuantityInStock--;
            Console.WriteLine("The vehicle is purchased!");
        }

        public void Rent()
        {
            QuantityInStock--;
            Console.WriteLine("The vehicle is rented!");
        }

        public void ReturnRental()
        {
            QuantityInStock++;
            Console.WriteLine("Vehicle has been returned!");
        }
    }

    public class BookModel : InventoryItemModel, IPurchaseable
    {
        public int NumberOfPages { get; set; }

        public void Purchase()
        {
            QuantityInStock--;
            Console.WriteLine("The book has been purchased!");
        }
    }
    public class ExcavatorModel : InventoryItemModel, IRentable
    {
        public void Dig()
        {
            Console.WriteLine("I am Digging!");
        }

        public void Rent()
        {
            QuantityInStock--;
            Console.WriteLine("This excavador has been rented!");
        }

        public void ReturnRental()
        {
            QuantityInStock++;
            Console.WriteLine("The excavador has been returned!");
        }
    }
}
