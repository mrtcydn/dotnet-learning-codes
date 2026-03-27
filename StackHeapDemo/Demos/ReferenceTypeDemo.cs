using StackHeapDemo.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace StackHeapDemo.Demos
{
    internal class ReferenceTypeDemo
    {
        static public void Run()
        {
            Console.WriteLine("[Reference Type Demo]");
            Box b1 = new Box();
            b1.Value = 44;

            Box b2 = b1; // b2 references the same object as b1
            Console.WriteLine($"b1.Value:{b1.Value}");
            Console.WriteLine($"b2.Value:{b2.Value}\n");

            b2.Value = 55; // Modifying b2's Value also modifies b1's Value
            Console.WriteLine($"b1.Value: {b1.Value}");
            Console.WriteLine($"b2.Value: {b1.Value}\n");
        }
    }
}
