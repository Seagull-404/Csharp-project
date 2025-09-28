using System;

namespace LogServices
{
    public class ConsoleLogProvider : ILogProvider
    {
        public void LogError(string message)
        {
            var color = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"[Error]: {message}");
            Console.ForegroundColor = color;
        }
        public void LogInfo(string message)
        {
            var color = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"[Info]: {message}");
            Console.ForegroundColor = color;
        }
    }
}
