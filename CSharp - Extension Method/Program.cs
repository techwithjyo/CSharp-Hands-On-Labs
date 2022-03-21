using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp___Extension_Method
{
    public static class WordExtension
    {
        public static int WordCountFromMethod(this string str)
        {
            string[] strArray = str.Split(' ');
            int wordCount = strArray.Length;
            return wordCount;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string content = "fafafaf afca af fs f sdf sf sdf sdf sdf sdf sdf s";

            int count = content.WordCountFromMethod();

            Console.WriteLine(count);
            Console.ReadLine();
        }
    }
}
