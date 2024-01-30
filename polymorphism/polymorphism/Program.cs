﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism
{
    class Program
    {
        static void Main()
        {
            int a = 2;
            int[] b = { 1, 2, 3 };
            MethodDemo obj = new MethodDemo();

            Console.WriteLine("a before = {0}", a);
            obj.PassByValue(a);
            Console.WriteLine("a after = {0}", a);

            Console.WriteLine("\n\n");

            Console.WriteLine("b[0] before = {0}", b[0]);
            obj.PassByReference(b);
            Console.WriteLine("b[0] after = {0}", b[0]);
            Console.ReadLine();
        }

    }
}
