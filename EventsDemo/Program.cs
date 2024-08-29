using System;
using System.Collections.Generic;

namespace EventsDemo
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // Create instances of CollegeClassModel with course title and max students
            CollegeClassModel history = new CollegeClassModel("History 101", 3);
            CollegeClassModel math = new CollegeClassModel("Math 101", 2);

            // Subscribe to the EnrollmentFull event using the event handler
            history.EnrollmentFull += CollegeClass_EnrollmentFull;

            // Sign up students and print the result to the console
            history.SignUpStudent("Alice").PrintToConsole();
            history.SignUpStudent("Bob").PrintToConsole();
            history.SignUpStudent("Charlie").PrintToConsole();
            history.SignUpStudent("David").PrintToConsole();
            history.SignUpStudent("Eve").PrintToConsole();

            // Subscribe to the EnrollmentFull event for the math class
            math.EnrollmentFull += CollegeClass_EnrollmentFull;

            // Sign up students and print the result to the console
            math.SignUpStudent("Alice").PrintToConsole();
            math.SignUpStudent("Bob").PrintToConsole();
            math.SignUpStudent("Dude").PrintToConsole();

            Console.ReadLine();
        }

        // Event handler for the History class enrollment full event
        public static void History_EnrollmentFull(object sender, string e)
        {
            Console.WriteLine();
            Console.WriteLine("The enrollment is full for History 101");
            Console.WriteLine();
        }

        // Event handler for the Math class enrollment full event 
        public static void Math_EnrollmentFull(object sender, string e)
        {
            Console.WriteLine();
            Console.WriteLine("The enrollment is full for Math 101");
            Console.WriteLine();
        }

        // General event handler for any class enrollment full event
        public static void CollegeClass_EnrollmentFull(object sender, string e)
        {
            CollegeClassModel model = (CollegeClassModel)sender;
            Console.WriteLine();
            Console.WriteLine($"{model.CourseTitle} : Full");
            Console.WriteLine();
        }
    }

    public static class ConsoleHelpers
    {
        // Extension method to print a message to the console
        public static void PrintToConsole(this string message)
        {
            Console.WriteLine(message);
        }
    }

    public class CollegeClassModel
    {
        // Declare the event using EventHandler<T>
        public event EventHandler<string> EnrollmentFull;

        private List<string> enrolledStudents = new List<string>();
        private List<string> waitingList = new List<string>();

        public string CourseTitle { get; set; }
        public int MaxStudents { get; set; }

        // Constructor to initialize the course title and max students
        public CollegeClassModel(string title, int maxStudents)
        {
            CourseTitle = title;
            MaxStudents = maxStudents;
        }

        // Method to sign up a student for the class
        public string SignUpStudent(string studentName)
        {
            string output = "";
            if (enrolledStudents.Count < MaxStudents)
            {
                enrolledStudents.Add(studentName);
                output = $"{studentName} is ENROLLED successfully in {CourseTitle}";
                if (enrolledStudents.Count == MaxStudents)
                {
                    // Invoke the EnrollmentFull event when the class is full
                    EnrollmentFull?.Invoke(this, $"{CourseTitle} enrollment is now full.");
                }
            }
            else
            {
                waitingList.Add(studentName);
                output = $"{studentName} is WAITLISTED for course {CourseTitle}";
            }

            return output;
        }
    }
}