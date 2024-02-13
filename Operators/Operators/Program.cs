using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate two Employee objects
            Employee employee1 = new Employee(1, "John", "Doe");
            Employee employee2 = new Employee(1, "John", "Doe");

            // Compare the two Employee objects using overloaded operators
            if (employee1 == employee2)
            {
                Console.WriteLine("Employees are equal based on Id.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Employees are not equal based on Id.");
                Console.ReadLine();
            }

        }
    }
}
