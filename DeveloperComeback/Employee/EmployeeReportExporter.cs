using System;

namespace DeveloperComeback.Services
{
    public class EmployeeReportExporter
    {
        public void Export(Employee employee)
        {
            Console.WriteLine(
                $"Exporting {employee.Name} to report...");
        }
    }
}