using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace CSharp___Async_Await_Sample
{
    public class Employee
    {
        public async Task<string> GetDataAsync()
        {
            HttpClient client = new HttpClient();
            Uri apiAddress = new Uri("https://jsonplaceholder.typicode.com/todos");

            var task = await client.GetAsync(apiAddress);
            if (task.IsSuccessStatusCode)
            {
                var data = await task.Content.ReadAsStringAsync();
                return data;
            }
            else
            {
                return null;
            }
        }
    }
    class Program
    {
        static async Task Main(string[] args)
        {
            Employee emp = new Employee();

            //var task = emp.GetDataAsync(); //synchronous call

            var task = await emp.GetDataAsync(); //Asynchronous call
            Console.WriteLine(task);
            Console.ReadLine();
        }
    }
}
