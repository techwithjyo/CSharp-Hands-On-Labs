using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp___Anonymous_Type
{
    class Book
    {
        public int BookId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Book> books = new List<Book>();
            books.Add(new Book { BookId = 1, Name = "C# Book", Price = 220M });
            books.Add(new Book { BookId = 2, Name = "JavaScript Book", Price = 2000M });

            //Anonymous Type Result Collection
            var result = (from book in books
                          where book.Price > 200
                          orderby book.Name descending
                          select new //Anonymous Type
                          {
                              Number = "#" + book.BookId,
                              Name = book.Name
                          });

            foreach (var item in result)
            {
                Console.WriteLine("Book Number : {0}, Name : {1}", item.Number, item.Name);
            }

            Console.ReadLine();
        }
    }
}
