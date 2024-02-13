using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    public class Employee
    {
        // Properties
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Constructor to initialize properties
        public Employee(int id, string firstName, string lastName)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
        }

        // Overload the "==" operator to compare Employees based on their Id
        public static bool operator ==(Employee employee1, Employee employee2)
        {
            // Check if both objects are null or if their Id properties are equal
            return ReferenceEquals(employee1, null) && ReferenceEquals(employee2, null) ||
                   !ReferenceEquals(employee1, null) && !ReferenceEquals(employee2, null) && employee1.Id == employee2.Id;
        }

        // Overload the "!=" operator to complement the "==" operator
        public static bool operator !=(Employee employee1, Employee employee2)
        {
            // Use the negation of the "==" operator result
            return !(employee1 == employee2);
        }
    }
}
