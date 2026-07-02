using DeveloperComeback.Interfaces;
using System;

namespace DeveloperComeback.Logging
{
    public class ConsoleLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine($"Output to console:\n{message}");
        }
    }
}
