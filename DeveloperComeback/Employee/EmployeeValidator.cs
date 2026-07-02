using System;

namespace DeveloperComeback.Services
{
    public class EmployeeValidator
    {
        public bool Validate(Employee employee)
        {
            if (employee == null)
                return false;

            if (string.IsNullOrWhiteSpace(employee.Name))
                return false;

            if (employee.Age < 18)
                return false;

            if (employee.Salary <= 0)
                return false;

            return true;
        }
    }
}