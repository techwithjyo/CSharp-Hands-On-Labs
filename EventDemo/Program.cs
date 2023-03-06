using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CollegeClassModel history = new CollegeClassModel("History 101", 3);

            CollegeClassModel math = new CollegeClassModel("Calculas 101", 2);

            history.EnrollStudent("Jyotirmoy").PrintToConsole();
            history.EnrollStudent("Person A").PrintToConsole();
            history.EnrollStudent("Person B").PrintToConsole();
            history.EnrollStudent("Person C").PrintToConsole();
            history.EnrollStudent("Person D").PrintToConsole();

            math.EnrollStudent("Jyotirmoy").PrintToConsole();
            math.EnrollStudent("Person A").PrintToConsole();
            math.EnrollStudent("Person B").PrintToConsole();

            Console.ReadLine();
        }
    }
    public static class ConsoleHelpers
    {
        public static void PrintToConsole(this string message)
        {
            Console.WriteLine( message);
        }
    }
    public class CollegeClassModel
    {
        List<string> enrolledStudent = new List<string>();
        List<string> waitingList = new List<string>();

        public string CourseTitle { get; private set; }
        public int MaximumStudents { get; private set; }
        public CollegeClassModel(string title, int maxStudents)
        {
            CourseTitle = title;
            MaximumStudents = maxStudents;
        }
        public string EnrollStudent(string studentName)
        {
            string output = "";
            if(enrolledStudent.Count < MaximumStudents)
            {
                enrolledStudent.Add(studentName);
                output = studentName + " was enrolled in " + CourseTitle;
            }
            else
            {
                waitingList.Add(studentName);
                output = studentName + " was added to the waitlist in " + CourseTitle;
            }
            return output;
        }
    }
}
