using System;


namespace MethodsAndObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            //Inside of the Main method, instantiate and initialize an Employee object with
            //the first name "Sample" and the last name "Student"
            Employee sam = new Employee() { FirstName = "Sample", LastName = "Student" };
            //Call the superclass method SayName() on the employee object
            sam.SayName();
            Console.ReadLine();
        }
    }
}
