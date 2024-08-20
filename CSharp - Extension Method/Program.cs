using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp___Extension_Method
{
    public static class WordExtension
    {
        //Must be static Class, Must be static method, This keyword is must

        //Extension methods in C# allow you to add new methods to existing types without modifying
        //the original type or creating a new derived type. They are defined as static methods
        //in a static class, but they are called as if they were instance methods on the extended type.
        public static int WordCountFromMethod(this string str)
        {
            string[] strArray = str.Split(' ');
            int wordCount = strArray.Length;
            return wordCount;
        }
        public static int WordCount(this string str)
        {
            if (string.IsNullOrWhiteSpace(str)) return 0;
            string[] words = str.Split(' ', (char)StringSplitOptions.RemoveEmptyEntries);
            return words.Length;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string content = "fafafaf afca af fs f sdf sf sdf sdf sdf sdf sdf s";

            int count = content.WordCountFromMethod();
            int wordCount = content.WordCount();

            Console.WriteLine($"Count: {count}, WordCount: {wordCount}");
            Console.ReadLine();
        }
    }
}
