using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    //Create another class, "Employee" and have it inherit from the Person class
    public class Employee : Person, IQuittable
    {
        public int Id { get; set; }
        //Implement the SayName() method inside of the employee class
        public override void SayName()
        {
            Console.WriteLine("Name: " + firstName + " " + lastName);
        }
        public void Quit()
        {

        }

        public void Quit(Person : Employee)
        {
            throw new NotImplementedException();
        }

       
    }
}
