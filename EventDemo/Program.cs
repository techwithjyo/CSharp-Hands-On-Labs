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

            history.EnrollmentFull += CollegeClass_EnrollmentFull; //listner

            history.EnrollStudent("Jyotirmoy").PrintToConsole();
            history.EnrollStudent("Person A").PrintToConsole();
            history.EnrollStudent("Person B").PrintToConsole();
            history.EnrollStudent("Person C").PrintToConsole();
            history.EnrollStudent("Person D").PrintToConsole();
            Console.WriteLine();

            math.EnrollmentFull += CollegeClass_EnrollmentFull;

            math.EnrollStudent("Jyotirmoy").PrintToConsole();
            math.EnrollStudent("Person A").PrintToConsole();
            math.EnrollStudent("Person B").PrintToConsole();

            Console.ReadLine();
        }

        private static void CollegeClass_EnrollmentFull(object sender, string e) //Combined method for Math + History
        {
            CollegeClassModel model = (CollegeClassModel)sender;

            Console.WriteLine();
            Console.WriteLine(model.CourseTitle + " is full!!");
            Console.WriteLine();

            //Console.WriteLine();
            //Console.WriteLine(e);
            //Console.WriteLine();
        }
        private static void Math_EnrollmentFull(object sender, string e)
        {
            Console.WriteLine();
            Console.WriteLine("The enrollment is full for Math!");
            Console.WriteLine();
        }

        private static void History_EnrollmentFull(object sender, string e) //listner
        {
            Console.WriteLine();
            Console.WriteLine("The enrollment is full for History!");
            Console.WriteLine();
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
        public event EventHandler<string> EnrollmentFull; //event handler

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
                if(enrolledStudent.Count == MaximumStudents)
                    EnrollmentFull?.Invoke(this, CourseTitle + " Enrollment is full.."); //invokation
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
