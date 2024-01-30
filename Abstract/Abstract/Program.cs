using System;


namespace Abstract
{
    class Program
    {
        static void Main(string[] args)
        {
            //In the Main method, instantiate an Employee object
            Employee name = new Employee() { firstName = "Andrew", lastName = "Marshall" };
            //Call the SayName method on the object
            name.SayName();
            Console.ReadLine();
        }
    }
}
