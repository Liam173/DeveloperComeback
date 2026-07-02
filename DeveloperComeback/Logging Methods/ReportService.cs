using DeveloperComeback.Interfaces;
using System;

namespace DeveloperComeback.Logging
{
    public class ReportService
    {
        public void LogMessage(ILogger loggerMethod, string message)
        {
            loggerMethod.Log(message);
        }
    }
}
