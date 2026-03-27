using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace StackHeapDemo.Demos
{
    internal class ValueTypeDemo
    {
        public static void Run()
        {
            Console.WriteLine("[Value Type Demo]");

            Point p1 = new Point();
            p1.X = 35;

            Point p2 = p1; // p2 is a copy of p1, they are independent
            Console.WriteLine($"p1.x: {p1.X}"); // Output: 35);
            Console.WriteLine($"p2.x: {p2.X}\n"); // Output: 35);

            p2.X = 50; // Modifying p2 does not affect p1

            Console.WriteLine($"p1.X: {p1.X}"); // Output: 35);
            Console.WriteLine($"p2.x: {p2.X}\n"); // Output: 50);
        }
    }
}
