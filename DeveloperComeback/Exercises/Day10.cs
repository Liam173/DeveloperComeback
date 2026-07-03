using DeveloperComeback.Exceptions;
using System;
using System.Runtime.InteropServices;

namespace DeveloperComeback.Exercises
{
    public static class Day10Exercises
    {
        public static void Run()
        {
            var repository = new EmployeeRepository();

            try
            {
                var employee = repository.GetById(5);
                Console.WriteLine(employee.Name);
            }
            catch (EmployeeNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception)
            {
                Console.WriteLine("Unexpected error.");
            }
            finally
            {
                Console.WriteLine("Finished searching.");
            }

            Console.WriteLine("Program continues...");
        }
    }
}
