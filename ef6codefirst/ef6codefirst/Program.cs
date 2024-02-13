using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace ef6codefirst
{
    class Program
    {
        static void Main(string[] args)
        {
            static void Main(string[] args)
            {

                using (var ctx = new SchoolContext())
                {
                    var stud = new Student() { StudentName = "Bill" };

                    ctx.Students.Add(stud);
                    ctx.SaveChanges();
                }
            }
    }
}
