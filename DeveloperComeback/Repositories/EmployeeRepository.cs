using DeveloperComeback.Interfaces;
using System;

namespace DeveloperComeback.Services
{
    public class EmployeeRepository : IEmployeeRepository
    {
        public void Save(Employee employee)
        {
            Console.WriteLine(
                $"Saving {employee.Name} to SQL Server...");
        }
    }
}