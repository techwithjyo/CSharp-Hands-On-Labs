using System;

namespace CSharp_Extension_Method_Demo_App
{
    public static class ExtendSimpleLogger
    {
        public static void LogError(this ISimpleLogger logger, string message)
        {
            var defualtColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Red;
            logger.Log(message, "Error");
            Console.ForegroundColor = defualtColor;
        }
        public static void LogWarning(this ISimpleLogger logger, string message)
        {
            var defualtColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Yellow;
            logger.Log(message, "Warning");
            Console.ForegroundColor = defualtColor;
        }
    }
}
