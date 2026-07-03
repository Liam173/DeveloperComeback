using DeveloperComeback.Exceptions;
using DeveloperComeback.Interfaces;
using System;

namespace DeveloperComeback
{
    public class EmployeeRepository : IEmployeeRepository
    {
        public void Save(Employee employee)
        {
            Console.WriteLine(
                $"Saving {employee.Name} to SQL Server...");
        }

        public Employee GetById(int id) 
        {
            if (id != 1)
            {
                throw new EmployeeNotFoundException(id);
            }

            return new Employee("Steve", 45, 6000m);
        }
    }
}