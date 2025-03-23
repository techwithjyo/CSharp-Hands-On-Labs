using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp___LINQ
{
    internal class Program
    {
        public class Product
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public decimal Price { get; set; }
        }

        public class Order
        {
            public int Id { get; set; }
            public string Customer { get; set; }
            public decimal Amount { get; set; }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello!!");
            List<Product> products = new List<Product>
            {
                new Product { Id = 1, Name = "Product 1", Price = 50 },
                new Product { Id = 2, Name = "Product 2", Price = 150 },
                new Product { Id = 3, Name = "Product 3", Price = 100 },
                new Product { Id = 4, Name = "Product 4", Price = 200 },
                new Product { Id = 5, Name = "Product 5", Price = 75 }
            };

            List<Order> orders = new List<Order>
            {
                new Order { Id = 1, Customer = "Alice", Amount = 100 },
                new Order { Id = 2, Customer = "Bob", Amount = 200 },
                new Order { Id = 3, Customer = "Alice", Amount = 150 },
                new Order { Id = 4, Customer = "Charlie", Amount = 250 },
                new Order { Id = 5, Customer = "Bob", Amount = 300 }
            };
            PerformLinqOperations(products, orders);
        }

        private static void PerformLinqOperations(List<Product> products, List<Order> orders)
        {
            //Filtering and Sorting
            var filteredAndSorted = products.Where(p => p.Price > 50)
                .OrderBy(p => p.Price)
                .Select(p => new { p.Name, p.Price });
            Console.WriteLine("Filtered and Sorted Products:");
            foreach (var product in filteredAndSorted)
            {
                Console.WriteLine($"{product.Name}: {product.Price}");
            }
            
            // Grouping and Aggregation
            var groupedOrders = orders.GroupBy(o => o.Customer)
                .Select(g => new
                {
                    Customer = g.Key,
                    TotalAmount = g.Sum(o => o.Amount)
                });

            Console.WriteLine("\nGrouped Orders:");
            foreach (var group in groupedOrders)
            {
                Console.WriteLine($"{group.Customer}: {group.TotalAmount}");
            }
            
            //Joining
            var joinedData = from order in orders
                join product in products on order.Id equals product.Id
                select new
                {
                    OrderId = order.Id,
                    Customer = order.Customer,
                    ProductName = product.Name,
                    Amount = order.Amount,
                    Price = product.Price
                };
            Console.WriteLine("\nJoined Data:");
            foreach (var item in joinedData)
            {
                Console.WriteLine($"OrderId: {item.OrderId}, Customer: {item.Customer}, Product: {item.ProductName}, Amount: {item.Amount}, Price: {item.Price}");
            }
            
            //Aggregation
            var totalOrderAmount = orders.Sum(o => o.Amount);
            Console.WriteLine($"\nTotal Order Amount: {totalOrderAmount}");

            var averageProductPrice = products.Average(p => p.Price);
            Console.WriteLine($"Average Product Price: {averageProductPrice}");
            
            var maxOrderAmount = orders.Max(o => o.Amount);
            Console.WriteLine($"Max Order Amount: {maxOrderAmount}");

            var minProductPrice = products.Min(p => p.Price);
            Console.WriteLine($"Min Product Price: {minProductPrice}");
        }
    }
}