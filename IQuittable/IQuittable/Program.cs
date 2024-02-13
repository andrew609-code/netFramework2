using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IQuittable
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an Employee object
            Employee employee = new Employee("John", "Doe");

            // Call the Quit method through the IQuittable interface
            IQuittable quittableEmployee = employee;
            quittableEmployee.Quit();

            // Wait for user input before closing the console window
            Console.ReadLine();
        }
    }
}
