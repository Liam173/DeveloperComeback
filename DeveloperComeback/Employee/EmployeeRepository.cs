using System;

namespace DeveloperComeback.Services
{
    public class EmployeeRepository
    {
        public void Save(Employee employee)
        {
            Console.WriteLine(
                $"Saving {employee.Name} to SQL Server...");
        }
    }
}