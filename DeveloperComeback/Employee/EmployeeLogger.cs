using System;

namespace DeveloperComeback.Services
{
    public class EmployeeLogger
    {
        public void Log(Employee employee)
        {
            Console.WriteLine(
                $"Employee {employee.Name} was processed.");
        }
    }
}