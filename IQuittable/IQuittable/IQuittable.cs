using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IQuittable
{
    public interface IQuittable
    {
        void Quit();
    }

    // Implement the interface in a class
    public class Employee : IQuittable
    {
        // Properties of an Employee
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Constructor
        public Employee(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        // Implementation of the Quit method from the IQuittable interface
        public void Quit()
        {
            Console.WriteLine($"{FirstName} {LastName} is quitting the job.");
        }
    }
}


