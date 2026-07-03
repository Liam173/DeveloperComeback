using DeveloperComeback.Services;
using System;

namespace DeveloperComeback.Exercises
{
    public static class Day09Exercises
    {
        public static void Run()
        {
            // Day 09 : Dependancy Injection
            var employee = new Employee("John", 30, 40000m);
            var employeeService = new EmployeeService(
                new EmployeeValidator(), 
                new EmployeeLogger(), 
                new EmployeeReportExporter(), 
                new EmployeeRepository());
            employeeService.RegisterEmployee(employee);
        }
    }
}
