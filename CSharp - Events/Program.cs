using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp___Events
{
    public class PrintHelper
    {
        // declare delegate 
        public delegate void Print();

        //declare event of type delegate
        public event Print beforePrintEvent;

        //declare event of type delegate
        public event Print afterPrintEvent;

        public void PrintText(string text)
        {
            //call delegate method before printing
            if (beforePrintEvent != null)
                beforePrintEvent();

            //printing text
            Console.WriteLine(text);

            //call delegate method after printing finished
            if (afterPrintEvent != null)
                afterPrintEvent();
        }
    }

    class Document
    {
        private PrintHelper printHelper;
        public Document()
        {
            printHelper = new PrintHelper();

            //subscribe to beforePrintEvent event
            printHelper.beforePrintEvent += beforePrintEventHandler;

            //subscribe to afterPrintEvent event
            printHelper.afterPrintEvent += afterPrintEventHandler;

        }

        //before Print event handler
        void beforePrintEventHandler()
        {
            Console.WriteLine("Printing Started..");
        }

        //after Print event handler
        void afterPrintEventHandler()
        {
            Console.WriteLine("Printing Finished..");
        }

        public void Print(string text)
        {
            printHelper.PrintText(text);
        }
    }

    class Program
    {
        static void Main()
        {
            Document doc = new Document();

            //call to print doc text
            doc.Print("Hello World Using Events in C#!");
            Console.ReadLine();
        }
    }
}
