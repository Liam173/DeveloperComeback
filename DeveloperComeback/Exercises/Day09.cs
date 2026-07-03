using DeveloperComeback.Interfaces;
using DeveloperComeback.Services;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace DeveloperComeback.Exercises
{
    public static class Day09Exercises
    {
        public static void Run()
        {
            // Day 09 : Dependancy Injection - Manual Constructor Injection
            var employee = new Employee("John", 30, 40000m);
            var employeeService = new EmployeeService(
                new EmployeeValidator(), 
                new EmployeeLogger(), 
                new EmployeeReportExporter(), 
                new EmployeeRepository());
            employeeService.RegisterEmployee(employee);

            // Dependancy Injection Containers
            var services = new ServiceCollection();
            services.AddTransient<EmployeeValidator>();
            services.AddTransient<EmployeeLogger>();
            services.AddTransient<EmployeeReportExporter>();
            services.AddTransient<IEmployeeRepository, EmployeeRepository>();
            services.AddTransient<EmployeeService>();

            var provider = services.BuildServiceProvider();
            var service = provider.GetRequiredService<EmployeeService>();

            service.RegisterEmployee(employee);
        }
    }
}
