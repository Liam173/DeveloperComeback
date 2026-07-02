using DeveloperComeback.Interfaces;
using System;

namespace DeveloperComeback.Logging
{
    public class FileLogger : ILogger
    {
        public void Log(string message)
        {
            // Simulate logging to a file by writing to the console
            Console.WriteLine($"Output to file:\n{message}");
        }
    }
}
